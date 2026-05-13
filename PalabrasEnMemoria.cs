namespace Ahorcado
{
    public class PalabrasEnMemoria : IRepositorioPalabras
    {
        private readonly Dictionary<string, List<string>> _categorias;

        private readonly string _categoriaSeleccionada;

        public PalabrasEnMemoria(string categoria)
        {
            _categoriaSeleccionada = categoria;

            _categorias = new Dictionary<string, List<string>>
            {
                {
                    "Arquitectura",
                    new List<string>
                    {
                        "arquitectura",
                        "componente",
                        "descomposicion",
                        "dependencia",
                        "acoplamiento"
                    }
                },

                {
                    "POO",
                    new List<string>
                    {
                        "polimorfismo",
                        "encapsulamiento",
                        "herencia",
                        "abstraccion",
                        "clase"
                    }
                },

                {
                    ".NET",
                    new List<string>
                    {
                        "ensamblado",
                        "namespace",
                        "interfaz",
                        "delegado",
                        "middleware"
                    }
                }
            };
        }

        public string ObtenerPalabraAleatoria()
        {
            var random = new Random();

            List<string> palabras =
                _categorias[_categoriaSeleccionada];

            return palabras[random.Next(palabras.Count)];
        }
    }
}