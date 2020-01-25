﻿
namespace SimpleTimer
{
    public interface IConfigurationValues
    {
        /// <summary>
        /// Exact as format but without symbols. Example: hhmmss
        /// </summary>
        string TimeFormatNoSymbols { get; }
        /// <summary>
        /// 
        /// </summary>
        string DetectSymbolInFormat { get; }
        /// <summary>
        /// Format to be used to parse text into a Timespan
        /// </summary>
        string TimeFormat { get; }
        /// <summary>
        /// 
        /// </summary>
        char FillCharInTimeFormat { get; }
        /// <summary>
        /// Filename of beeping sound
        /// </summary>
        string RingtoneFilename { get; }
        string ErrorTitle { get; }
        /// <summary>
        /// Initial text for textbox (must match time format)
        /// </summary>
        string InitialText { get; }

        string PrimaryButtonStart { get; }
        string PrimaryButtonStop { get; }
        string PrimaryButtonOK { get; }
        /// <summary>
        /// How many seconds should beeping should play
        /// </summary>
        int TimerBeepingSeconds { get; }
        int TimerInterval { get; }
    }
}
