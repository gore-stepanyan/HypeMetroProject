using System;

namespace Metro
{
    class Simulation
    {
        private Metro myMetro;
        private DateTime startTime = new DateTime();
        private DateTime finishTime = new DateTime();
        private DateTime currentTime = new DateTime();

        public DateTime CurrentTime
        {
            get { return currentTime; }
        }

        public Simulation(DateTime startTime, DateTime finishTime, Metro myMetro)
        {
            if (startTime < finishTime)
            {
                this.startTime = startTime;
                this.finishTime = finishTime;
                this.myMetro = myMetro;
            }
            else 
            {
                throw new Exception("Некорректно указан интервал моделирования");
            }
        }

        // Моделирование работы метро в течение всего интервала времени
        public void Run()
        {
            // Подготовка базы данных
            MetroData.StartTime = startTime;
            MetroData.FinishTime = finishTime;
            MetroData.TransportationCount = 0;
            MetroData.TotalNumberOfPeople = 0;
            MetroData.PeopleStats.Clear();

            currentTime = startTime;
            while (currentTime < finishTime)
            {
                myMetro.Run(currentTime);
                currentTime = myMetro.CurrentTime;
            }
        }
    }
}