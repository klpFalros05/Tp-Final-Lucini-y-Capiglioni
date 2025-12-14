using Controladora.Dtos;
using Entidades;
using Modelo;


namespace Controladora
{
    public class ControladoraClientes
    {
            private static ControladoraClientes? _instancia;
            public static ControladoraClientes Instancia => _instancia ??= new ControladoraClientes();

            private readonly RepositorioClientes repo;

            private ControladoraClientes()
            {
                repo = new RepositorioClientes();
            }

            public List<ClienteDto> ListarTodosParaGrilla()
                => Mapear(repo.ListarTodos());

            public List<ClienteDto> ListarMayoristasParaGrilla()
                => repo.ListarMayoristas()
                        .Select(m => new ClienteDto
                        {
                            ClienteId = m.ClienteId,
                            Tipo = "Mayorista",
                            Nombre = m.Nombre,
                            Apellido = m.Apellido,
                            DescuentoPorcentaje = m.Descuento * 100m,
                            EstadoCuenta = m.EstadoCuenta.ToString(),
                            MontoDebe = m.MontoDebe
                        })
                        .ToList();

            public List<ClienteDto> ListarMinoristasParaGrilla()
                => repo.ListarMinoristas()
                        .Select(m => new ClienteDto
                        {
                            ClienteId = m.ClienteId,
                            Tipo = "Minorista",
                            Nombre = m.Nombre,
                            Apellido = m.Apellido,
                            DescuentoPorcentaje = m.Descuento * 100m,
                            EstadoCuenta = "",
                            MontoDebe = 0m
                        })
                        .ToList();

            private List<ClienteDto> Mapear(List<Cliente> clientes)
            {
                var lista = new List<ClienteDto>();

                foreach (var c in clientes)
                {
                    if (c is Mayorista may)
                    {
                        lista.Add(new ClienteDto
                        {
                            ClienteId = may.ClienteId,
                            Tipo = "Mayorista",
                            Nombre = may.Nombre,
                            Apellido = may.Apellido,
                            DescuentoPorcentaje = may.Descuento * 100m,
                            EstadoCuenta = may.EstadoCuenta.ToString(),
                            MontoDebe = may.MontoDebe
                        });
                    }
                    else if (c is Minorista min)
                    {
                        lista.Add(new ClienteDto
                        {
                            ClienteId = min.ClienteId,
                            Tipo = "Minorista",
                            Nombre = min.Nombre,
                            Apellido = min.Apellido,
                            DescuentoPorcentaje = min.Descuento * 100m,
                            EstadoCuenta = "",
                            MontoDebe = 0m
                        });
                    }
                }

                return lista;
            }

            public void Agregar(string tipo, string nombre, string apellido, decimal descuentoPorcentaje)
            {
                Validar(nombre, apellido, descuentoPorcentaje);

                decimal descuentoDecimal = descuentoPorcentaje / 100m;

                if (tipo == "Mayorista")
                {
                    var may = new Mayorista
                    {
                        Nombre = nombre.Trim(),
                        Apellido = apellido.Trim(),
                        Descuento = descuentoDecimal,
                        EstadoCuenta = EstadoDeCuenta.AlDia,
                        MontoDebe = 0m
                    };
                    repo.Agregar(may);
                }
                else
                {
                    var min = new Minorista
                    {
                        Nombre = nombre.Trim(),
                        Apellido = apellido.Trim(),
                        Descuento = descuentoDecimal
                    };
                    repo.Agregar(min);
                }
            }

            public void Modificar(int clienteId, string nombre, string apellido, decimal descuentoPorcentaje)
            {
                Validar(nombre, apellido, descuentoPorcentaje);

                decimal descuentoDecimal = descuentoPorcentaje / 100m;

                repo.Modificar(clienteId, nombre.Trim(), apellido.Trim(), descuentoDecimal);
            }

            public void Eliminar(int clienteId)
            {
                repo.Eliminar(clienteId);
            }

            private void Validar(string nombre, string apellido, decimal descuentoPorcentaje)
            {
                if (string.IsNullOrWhiteSpace(nombre)) throw new Exception("El nombre es obligatorio.");
                if (string.IsNullOrWhiteSpace(apellido)) throw new Exception("El apellido es obligatorio.");
                if (descuentoPorcentaje < 0 || descuentoPorcentaje > 100) throw new Exception("El descuento debe estar entre 0 y 100.");
            }
        }
}
