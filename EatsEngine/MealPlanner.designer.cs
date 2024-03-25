using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model {
    /// <summary>
    /// 
    /// </summary>
    public partial class MealPlanner {

        /// <summary>
        /// 
        /// </summary>
        public virtual void Day { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual void Meal { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual void Recipe { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual void MealPlanner();

    }
}