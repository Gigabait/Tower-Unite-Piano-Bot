﻿namespace Tower_Unite_Instrument_Autoplayer.Core
{
    /// <summary>
    /// This class defines a SpeedChangeNote which is a note
    /// that will change the speed of the delay between notes being played
    /// It needs a boolean value to define wheather or not to turn on
    /// the faster speed
    /// </summary>
    class SpeedChangeNote : INote
    {
        public bool TurnOnFast { get; private set; }

        public SpeedChangeNote(bool turnOnFast)
        {
            TurnOnFast = TurnOnFast;
        }

        public void Play()
        {
            Program.ChangeSpeed(TurnOnFast);
        }
    }
}
