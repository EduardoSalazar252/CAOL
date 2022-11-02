using DataLibrary;
using Microsoft.EntityFrameworkCore;
using Org.BouncyCastle.Asn1.Utilities;
using System;
using System.Collections.Generic;
using System.Xml.Linq;
using Test_Práctico_Agence.Model;
using Test_Práctico_Agence.Models;
using static Org.BouncyCastle.Math.EC.ECCurve;

namespace Test_Práctico_Agence.Models
{
    public class Funciones
    {
        private readonly IDataAccess _data;
        private readonly IConfiguration _config;
        public Funciones(IDataAccess data, IConfiguration config)
        {
            _data = data;
            _config = config;
        }

        public List<Info_Mes> GetListaMeses()
        {
            //-------------------------------------------------------------
            //Aquí se genera la lista de los meses cumpliendo el formato
            //creado como Info_Mes obteniendo y guardando la información
            //para cada atributo del modelo
            //-------------------------------------------------------------
            List<Info_Mes> _ListaFinal = new();
            Info_Mes nuevoMes = new();
            for (int i = 1; i < 13; i++)
            {
                string? sigla = null;
                string? nombre = null;
                switch (i)
                {
                    case 1:
                        sigla = "Jan";
                        nombre = "Janeiro";
                        break;
                    case 2:
                        sigla = "Fev";
                        nombre = "Fevereiro";
                        break;
                    case 3:
                        sigla = "Mar";
                        nombre = "Março";
                        break;
                    case 4:
                        sigla = "Abr";
                        nombre = "Abril";
                        break;
                    case 5:
                        sigla = "Mai";
                        nombre = "Maio";
                        break;
                    case 6:
                        sigla = "Jun";
                        nombre = "Junho";
                        break;
                    case 7:
                        sigla = "Jul";
                        nombre = "Julho";
                        break;
                    case 8:
                        sigla = "Ago";
                        nombre = "Agosto";
                        break;
                    case 9:
                        sigla = "Set";
                        nombre = "Setembro";
                        break;
                    case 10:
                        sigla = "Out";
                        nombre = "Outubro";
                        break;
                    case 11:
                        sigla = "Nov";
                        nombre = "Novembro";
                        break;
                    case 12:
                        sigla = "Dez";
                        nombre = "Dezembro";
                        break;
                }
                nuevoMes = new Info_Mes()
                {
                    Mes_Numero = i,
                    Mes_Sigla = sigla,
                    Mes_Nombre = nombre
                };
                _ListaFinal.Add(nuevoMes);
            }
            _ListaFinal.Sort((x, y) => x.Mes_Numero.CompareTo(y.Mes_Numero));
            return _ListaFinal;
        }

        public List<int> GetListaAnos()
        {
            //-------------------------------------------------------------
            //Aquí se genera la lista de los años que aparecerán en la 
            //sección de periodo. El valor inicial de esta lista es 2000
            //y se irá generando dinamicamente tomando en cuenta el año
            //actual
            //-------------------------------------------------------------
            List<int> _listaAnos = new();
            int year = 2000;
            int actual_actual = DateTime.Now.Year;
            for (int i = year; i < actual_actual; i++)
            {
                year++;
                _listaAnos.Add(year);
            }
            _listaAnos.Sort((x, y) => y.CompareTo(x));
            return _listaAnos;
        }

        public async Task<List<Info_Usuario>> GetListaUsuarios(string sql)
        {
            //-------------------------------------------------------------
            //Aquí se genera la lista de los usuarios cumpliendo las
            //especificaciones del enunciado, utilizando 2 tablas
            //cao_usuario y permissao_sistema y haciendo el join a través
            //de co_usuario. Esta lista cumple con el formato del Modelo
            //Info_Usuario donde se registrará 2 atributos
            //-------------------------------------------------------------
            List<Info_Usuario> _listaUsuarios = new();

            List<cao_usuario> _Consultores = await _data.LoadData<cao_usuario, dynamic>(sql, new { }, _config.GetConnectionString("caol"));

            if (_Consultores.Count > 0)
            {
                foreach (var c in _Consultores)
                {
                    Info_Usuario newUsuario = new Info_Usuario()
                    {
                        Usuario_co = c.co_usuario,
                        Usuario_no = c.no_usuario
                    };
                    _listaUsuarios.Add(newUsuario);
                }
                _listaUsuarios.Sort((x, y) => x.Usuario_no.CompareTo(y.Usuario_no));
            }

            return _listaUsuarios;
        }

        public async Task<List<Data_Usuario>> GetInfoMonetaria(List<Info_Usuario> usuarios, Data_Periodo p_inicio, Data_Periodo p_fin)
        {
            //-------------------------------------------------------------
            //Aquí se genera la lista de los Usuarios seleccionados y
            //cumpliendo a su vez con el modelo Data_Usuario, donde se 
            //organizará y registrará la información monetaria de cada
            //usuario tomando en cuenta el periodo seleccionado
            //-------------------------------------------------------------
            List<Data_Usuario> data_Usuarios = new();

            foreach (var u in usuarios)
            {
                List<cao_fatura> facturas_porusuario = new();

                List<cao_salario> salario_porusuario = new();

                float costo_fijo = 0;

                List<Info_Periodo> info_Periodo = new();

                //Aquí se generán los queries para buscar la data monetaria de los usuarios en la base de datos

                string sql_facturas = "SELECT * FROM cao_fatura as A INNER JOIN cao_os as B WHERE A.co_os = B.co_os AND B.co_usuario ='" + u.Usuario_co + "'";

                string sql_costofijo = "SELECT brut_salario FROM cao_salario as A WHERE A.co_usuario = '" + u.Usuario_co + "'";

                facturas_porusuario = await _data.LoadData<cao_fatura, dynamic>(sql_facturas, new { }, _config.GetConnectionString("caol"));

                salario_porusuario = await _data.LoadData<cao_salario, dynamic>(sql_costofijo, new { }, _config.GetConnectionString("caol"));

                //Aquí se obtiene el salario bruto o costo fijo del ususario
                if (salario_porusuario.Count > 0)
                {
                    foreach (var spu in salario_porusuario)
                    {
                        costo_fijo = spu.brut_salario;
                    }
                }

                if (facturas_porusuario.Count > 0)
                {
                    List<DateTime> lista_fechas = new();

                    //Aquí se optienen el primer día del mes de inicio y ultimo día del mes de fin seleccionado  
                    Info_Periodos fechas_periodos = GeneradorFechasInicioFin(p_inicio.D_year, p_inicio.D_mes, p_fin.D_year, p_fin.D_mes);                                 

                    //Aquí se optienen la cantidad total de meses. Este resultado será utilizado para generar la lista
                    //final de meses que se utilizará para organizar la información monetaria y el eje X del gráfico

                    int cantidad_meses = GetMonthDifference(fechas_periodos.Periodo_Inicio, fechas_periodos.Periodo_Fin);

                    for (int i = 0; i < cantidad_meses; i++)
                    {
                        DateTime fecha_analisis = fechas_periodos.Periodo_Inicio.AddMonths(i);
                        lista_fechas.Add(fecha_analisis);
                    }

                    if (lista_fechas.Count > 0)
                    {
                        foreach (var lf in lista_fechas)
                        {
                            //Aquí se optienen el primer día del mes de inicio y ultimo día del mes de fin seleccionado  del
                            //item de la lista de meses previamente llenada

                            Info_Periodos lf_periodos = GeneradorFechasInicioFin(lf.Year, lf.Month, lf.Year, lf.Month);

                            //Aquí se busca dentro de la lista cao_factura del usuario si existen registros de su información
                            //monetaria dentro del mes anteriormente obtenido

                            List<cao_fatura> temp_facturas_porusuario = facturas_porusuario.
                                   Where(x => (x.data_emissao.Date >= lf_periodos.Periodo_Inicio.Date) &&
                                        (x.data_emissao.Date <= lf_periodos.Periodo_Fin.Date)).ToList();

                            if (temp_facturas_porusuario.Count > 0)
                            {                                
                                string _periodo = "";
                                float _recetatotal = 0;
                                float _comisiontotal = 0;
                                float _lucrototal = 0;

                                //Si existen datos, generamos el string que se mostrará en el eje x del gráfico y del la seccion
                                //izquierda de la tabla
                                switch (lf_periodos.Periodo_Inicio.Month)
                                {
                                    case 1:
                                        _periodo = "Janeiro " + Convert.ToString(lf_periodos.Periodo_Inicio.Year);
                                        break;
                                    case 2:
                                        _periodo = "Fevereiro " + Convert.ToString(lf_periodos.Periodo_Inicio.Year); ;
                                        break;
                                    case 3:
                                        _periodo = "Março " + Convert.ToString(lf_periodos.Periodo_Inicio.Year); ;
                                        break;
                                    case 4:
                                        _periodo = "Abril " + Convert.ToString(lf_periodos.Periodo_Inicio.Year); ;
                                        break;
                                    case 5:
                                        _periodo = "Maio " + Convert.ToString(lf_periodos.Periodo_Inicio.Year); ;
                                        break;
                                    case 6:
                                        _periodo = "Junho " + Convert.ToString(lf_periodos.Periodo_Inicio.Year); ;
                                        break;
                                    case 7:
                                        _periodo = "Julho " + Convert.ToString(lf_periodos.Periodo_Inicio.Year); ;
                                        break;
                                    case 8:
                                        _periodo = "Agosto " + Convert.ToString(lf_periodos.Periodo_Inicio.Year); ;
                                        break;
                                    case 9:
                                        _periodo = "Setembro " + Convert.ToString(lf_periodos.Periodo_Inicio.Year); ;
                                        break;
                                    case 10:
                                        _periodo = "Outubro " + Convert.ToString(lf_periodos.Periodo_Inicio.Year); ;
                                        break;
                                    case 11:
                                        _periodo = "Novembro " + Convert.ToString(lf_periodos.Periodo_Inicio.Year); ;
                                        break;
                                    case 12:
                                        _periodo = "Dezembro " + Convert.ToString(lf_periodos.Periodo_Inicio.Year); ;
                                        break;
                                }

                                //Aquí calculamos y registramos los 3 valores principales que se necesitán para llenar la tabla 
                                //de relatório. Haciendo la sumatoria del valor obtenido después de haber efectuado el calculo
                                //siguiendo las formaulas indicadas en las instrucciones

                                foreach (var tfpu in temp_facturas_porusuario)
                                {                                    
                                    float valor = tfpu.valor - (tfpu.total_imp_inc / 100);
                                    _recetatotal = _recetatotal + valor;
                                    float comision = (tfpu.valor * (1 - (tfpu.total_imp_inc / 100))) * (tfpu.comissao_cn / 100);
                                    _comisiontotal = _comisiontotal + comision;
                                    float lucro = (valor - (costo_fijo + comision));
                                    _lucrototal = _lucrototal + lucro;
                                }

                                //Completamos el modelo Info_Periodo que se agregará al modelo Data_Usuario
                                Info_Periodo newI_Periodo = new Info_Periodo()
                                {
                                    Periodo_Mes = _periodo,
                                    Periodo_Recetaliquida = _recetatotal,
                                    Periodo_Comision = _comisiontotal,
                                    Periodo_Lucro = _lucrototal
                                };
                                info_Periodo.Add(newI_Periodo);
                            }
                        }
                    }
                }

                //Terminamos de completar el model Data_Usuario del usuario en cuestión y se agrega a la lista final
                Data_Usuario newDataUsuario = new Data_Usuario()
                {
                    D_usuario = u,
                    D_custofijo = costo_fijo,
                    D_monetario = info_Periodo
                };
                data_Usuarios.Add(newDataUsuario);
            }
            return data_Usuarios;
        }

        public static int GetMonthDifference(DateTime startDate, DateTime endDate)
        {
            //Aquí se calcula la diferencia de meses que existe entre los periodos seleccionados
            int monthsApart = 12 * (startDate.Year - endDate.Year) + startDate.Month - endDate.Month;
            return Math.Abs(monthsApart);
        }

        public Info_Periodos GeneradorFechasInicioFin(int inicio_yyyy, int inicio_mm, int fin_yyyy, int fin_mm)
        {
            //Aquí generamos la fecha de inicio del mes del periodo seleccionado y la fecha del último día del mes del 
            //periodo selecciado. Y guardamos la data siguiendo el modelo Info_Periodos creado

            string inicio_year = Convert.ToString(inicio_yyyy);
            string inicio_month = Convert.ToString(inicio_mm);
            string inicio_day = "01";
            string inicio_date = inicio_year + "-" + inicio_month + "-" + inicio_day;

            string fin_year = Convert.ToString(fin_yyyy);
            string fin_month = Convert.ToString(fin_mm);            
            string fin_day = Convert.ToString(DateTime.DaysInMonth(fin_yyyy, fin_mm));//Aquí se obtiene el último día del mes
            string fin_date = fin_year + "-" + fin_month + "-" + fin_day;

            DateTime fechad_inicio = Convert.ToDateTime(inicio_date);
            DateTime fechad_fin = Convert.ToDateTime(fin_date);

            Info_Periodos resultado = new Info_Periodos()
            {
                Periodo_Inicio = fechad_inicio,
                Periodo_Fin = fechad_fin
            };
            return resultado;
        }

        public Tuple<List<Data_Usuario>, List<string>, string, float> GetDataForGraph(List<Data_Usuario> data_Usuarios)
        {
            //Aquí organizamos la data que se utilizará para la creación del gráfico de barras.
            //Esta función retorna 4 valores, por ese motivo es de tipo tuple. La data obtenida aquí es la siguiente
            //data_Usuarios,
            //listademeses (Que nos ayudará a generar los valores del eje X y organizar la data)
            //titulo (El titulo del gráfico generado dinamicamente y mostrando los periodos seleccionados)
            //salarioBrutoTotal (el promedio del salario bruto que se utilizará para generar la linea del gráfico)

            List<string> listademeses = new();
            List<Data_Usuario> tem_data_Usuario = new();
            float salarioBruto = 0;

            //Se obtiene la lista de meses general y se depura removiendo la duplicidad
            foreach (var item in data_Usuarios)
            {
                foreach (var it in item.D_monetario)
                {
                    listademeses.Add(it.Periodo_Mes);
                }
            }
            listademeses = listademeses.Distinct().ToList();

            foreach (var du in data_Usuarios)
            {
                List<Info_Periodo> templist = new();
                salarioBruto = salarioBruto + du.D_custofijo;
                foreach (var lm in listademeses)
                {
                    var result = du.D_monetario.Find(x => x.Periodo_Mes == lm);
                    //En el caso de que no se encuentre un resultado generamos una información con valores en 0 para el mes
                    //en cuestion
                    if (result == null)
                    {
                        Info_Periodo newIperiodo = new Info_Periodo()
                        {
                            Periodo_Mes = lm,
                            Periodo_Recetaliquida = 0,
                            Periodo_Comision = 0,
                            Periodo_Lucro = 0

                        };
                        templist.Add(newIperiodo);
                    }
                    else
                    {
                        templist.Add(result);
                        du.D_monetario.Remove(result);
                    }
                }
                du.D_monetario = templist;
            }
            
            float salarioBrutoTotal = salarioBruto / data_Usuarios.Count;

            string titulo = "Desempeño del consultor " + listademeses.First() + " a " + listademeses.Last();
            var resultado = new Tuple<List<Data_Usuario>, List<string>, string, float>(data_Usuarios, listademeses, titulo, salarioBrutoTotal);
            return resultado;
        }

        public Tuple<List<Info_Pie>, float> GetDataForPie(List<Data_Usuario> data_Usuarios)
        {
            //Aquí organizamos la data que se utilizará para la creación del gráfico tipo Pie o Pizza.
            //Esta función retorna 2 valores, por ese motivo es de tipo tuple. La data obtenida aquí es la siguiente
            //InfoPie (Por cada usuario obtenemos el total de la receta liquida),
            //total (Se registra el total de la receta para poder obtener el % que representa la receta del usuario, con
            //respecto a la totalidad de usuarios en la lista)

            List<Info_Pie> InfoPie = new();
            float total = 0;
            foreach (var du in data_Usuarios)
            {
                float totalreceta = 0;
                foreach (var dum in du.D_monetario)
                {
                    totalreceta = totalreceta + dum.Periodo_Recetaliquida;
                }
                total = total + totalreceta;
                Info_Pie newIpie = new Info_Pie()
                {
                    Pie_Nombre = du.D_usuario.Usuario_no,
                    Pie_Receta = totalreceta
                };
                InfoPie.Add(newIpie);
            }
            var resultado = new Tuple<List<Info_Pie>, float>(InfoPie, total);
            return resultado;
        }

        public bool DatesCompare(int year_i, int mes_i, int year_f, int mes_f)
        {
            //Aqui comparamos el periodo de inicio y el periodo de fin en el caso de que el periodo inicial sea superior al
            //periodo final. Arrojamos un mensaje de error al usuario.

            bool result = true;
            Info_Periodos fechas = GeneradorFechasInicioFin(year_i, mes_i, year_f, mes_f);
            if (fechas.Periodo_Inicio.Date > fechas.Periodo_Fin.Date)
            {
                result = false;
            }
            return result;
        }
    }
}
