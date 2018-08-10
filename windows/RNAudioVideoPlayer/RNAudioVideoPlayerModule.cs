using ReactNative.Bridge;
using System;
using System.Collections.Generic;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;

namespace Audio.Video.Player.RNAudioVideoPlayer
{
    /// <summary>
    /// A module that allows JS to share data.
    /// </summary>
    class RNAudioVideoPlayerModule : NativeModuleBase
    {
        /// <summary>
        /// Instantiates the <see cref="RNAudioVideoPlayerModule"/>.
        /// </summary>
        internal RNAudioVideoPlayerModule()
        {

        }

        /// <summary>
        /// The name of the native module.
        /// </summary>
        public override string Name
        {
            get
            {
                return "RNAudioVideoPlayer";
            }
        }
    }
}
