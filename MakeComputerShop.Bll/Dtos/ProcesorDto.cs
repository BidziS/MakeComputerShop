using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MakeComputerShop.Bll.Dtos.MotherboardElementsDto;

namespace MakeComputerShop.Bll.Dtos
{
    public class ProcesorDto:BaseDto
    {
        public ProducentDto Producent { get; set; }

        public byte NumberOfCores { get; set; }

        public byte NumberOfThreads { get; set; }

        public byte Cache { get; set; }

        public double Frequency { get; set; }

        public SocketDto Socket { get; set; }

        public override bool Equals(object obj)
        {
            var toCompareWith = obj as ProcesorDto;
            if (toCompareWith == null)
                return false;
            return this.Id == toCompareWith.Id &&
                   this.Name == toCompareWith.Name &&
                   this.Producent == toCompareWith.Producent &&
                   this.NumberOfCores == toCompareWith.NumberOfCores &&
                   this.NumberOfThreads == toCompareWith.NumberOfThreads &&
                   this.Cache == toCompareWith.Cache &&
                   this.Frequency == toCompareWith.Frequency &&
                   this.Socket == toCompareWith.Socket;

        }
}
}
