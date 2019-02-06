using ReactNative.Bridge;
using System;
using System.Collections.Generic;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;

namespace Accounts.RNAccounts
{
    /// <summary>
    /// A module that allows JS to share data.
    /// </summary>
    class RNAccountsModule : NativeModuleBase
    {
        /// <summary>
        /// Instantiates the <see cref="RNAccountsModule"/>.
        /// </summary>
        internal RNAccountsModule()
        {

        }

        /// <summary>
        /// The name of the native module.
        /// </summary>
        public override string Name
        {
            get
            {
                return "RNAccounts";
            }
        }
    }
}
