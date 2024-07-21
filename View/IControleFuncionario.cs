using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFuncionario.View
{
    public interface IControleFuncionario
    {
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Function {  get; set; }
    }
}
