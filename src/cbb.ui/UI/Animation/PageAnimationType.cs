using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cbb.ui
{
    public enum PageAnimationType
    {
        /// <summary>
        /// No animation.
        /// </summary>
        None,
        /// <summary>
        /// The fade animation based on opacity property
        /// </summary>
        Fade,
        /// <summary>
        /// The slide animation based on transform
        /// </summary>
        Slide
    }
}
