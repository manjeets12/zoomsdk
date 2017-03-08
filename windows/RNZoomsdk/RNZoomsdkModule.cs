using ReactNative.Bridge;
using System;
using System.Collections.Generic;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;

namespace Com.Reactlibrary.RNZoomsdk
{
    /// <summary>
    /// A module that allows JS to share data.
    /// </summary>
    class RNZoomsdkModule : NativeModuleBase
    {
        /// <summary>
        /// Instantiates the <see cref="RNZoomsdkModule"/>.
        /// </summary>
        internal RNZoomsdkModule()
        {

        }

        /// <summary>
        /// The name of the native module.
        /// </summary>
        public override string Name
        {
            get
            {
                return "RNZoomsdk";
            }
        }
    }
}
