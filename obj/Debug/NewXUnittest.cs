using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace Ingenieria_en_software_2.obj.Debug
{
    public class NewXUnittest
    {
        [Fact]
        public void DebeCrearNuevaCarpeta()
        {
            
           Carpeta carpeta = new Carpeta("nueva_carpeta", peso);

            Assert.Equal("nueva_carpeta", carpeta.Nombre);
            Assert.Equal(13, carpeta.Peso);
        }
    }
}