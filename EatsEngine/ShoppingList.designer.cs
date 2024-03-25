using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model {
    /// <summary>
    /// 
    /// </summary>
    public partial class ShoppingList {

        /// <summary>
        /// 
        /// </summary>
        public virtual void Ingredients { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual void GenerateList();

    }
}