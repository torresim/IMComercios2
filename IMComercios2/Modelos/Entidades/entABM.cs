using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMComercios.Modelos.Entidades
{
    /// <summary>
    /// Entidad ABM
    /// </summary>
    public class entABM
    {
        /// <summary>
        /// A que tabla de la base de datos hace referencia el ABM
        /// </summary>
        public string Tabla { get; set; }

        /// <summary>
        /// Cuales son las columnas visibles de la tabla
        /// </summary>
        public IEnumerable<string> Columnas { get; set; }

        /// <summary>
        /// Palabra clave para efectuar la busqueda y el filtrado
        /// </summary>
        public string Filtro { get; set; } = "";

        /// <summary>
        /// Columna que se utilizara como campo clave o indice para el ABM
        /// </summary>
        public string Clave { get; set; }
    }
}
