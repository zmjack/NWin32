namespace NWin32
{
    public partial class NativeConstants
    {
        #region esFlags
        /// <summary>
        /// DE_REQUIRED
        /// 0x00000040
        /// Enables away mode.This value must be specified with ES_CONTINUOUS.
        /// Away mode should be used only by media-recording and media-distribution applications that must perform critical background processing on desktop computers while the computer appears to be sleeping.See Remarks.
        /// </summary>
        /// <see cref="https://msdn.microsoft.com/en-us/library/aa373208.aspx"/>
        public const uint ES_AWAYMODE_REQUIRED = 0x00000040;

        /// <summary>
        /// Informs the system that the state being set should remain in effect until the next call that uses ES_CONTINUOUS and one of the other state flags is cleared.
        /// </summary>
        /// <see cref="https://msdn.microsoft.com/en-us/library/aa373208.aspx"/>
        public const uint ES_CONTINUOUS = 0x80000000;

        /// <summary>
        /// Forces the display to be on by resetting the display idle timer.
        /// </summary>
        /// <see cref="https://msdn.microsoft.com/en-us/library/aa373208.aspx"/>
        public const uint ES_DISPLAY_REQUIRED = 0x00000002;

        /// <summary>
        /// Forces the system to be in the working state by resetting the system idle timer.
        /// </summary>
        /// <see cref="https://msdn.microsoft.com/en-us/library/aa373208.aspx"/>
        public const uint ES_SYSTEM_REQUIRED = 0x00000001;

        /// <summary>
        /// This value is not supported. If ES_USER_PRESENT is combined with other esFlags values, the call will fail and none of the specified states will be set.
        /// </summary>
        /// <see cref="https://msdn.microsoft.com/en-us/library/aa373208.aspx"/>
        public const uint ES_USER_PRESENT = 0x00000004;
        #endregion

    }
}
