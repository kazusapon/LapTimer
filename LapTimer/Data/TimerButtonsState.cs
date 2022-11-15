using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LapTimer.Data
{
    public class TimerButtonsState
    {
        public bool TimerStartButtonDisabled { get; set; }

        public bool TimerStopButtonDisabled { get; set;}

        public bool TimerResetButtonDisabled { get; set; }

        public TimerButtonsState()
        {
            TimerReset();
        }

        public void TimerStart()
        {
            this.TimerStartButtonDisabled = true;
            this.TimerStopButtonDisabled = false;
            this.TimerResetButtonDisabled = true;
        }

        public void TimerStop()
        {
            this.TimerStartButtonDisabled = false;
            this.TimerStopButtonDisabled = true;
            this.TimerResetButtonDisabled = false;
        }

        public void TimerReset()
        {
            this.TimerStartButtonDisabled = false;
            this.TimerStopButtonDisabled = true;
            this.TimerResetButtonDisabled = true;
        }
    }
}
