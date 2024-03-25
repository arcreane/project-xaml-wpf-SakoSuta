using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model {
    /// <summary>
    /// 
    /// </summary>
    public partial class KitchenRobot {

        /// <summary>
        /// 
        /// </summary>
        public virtual void State { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual void Chop();

        /// <summary>
        /// 
        /// </summary>
        public virtual void Mix();

        /// <summary>
        /// 
        /// </summary>
        public virtual void Cut();

        /// TODO: Other instructionion to come

    }
}