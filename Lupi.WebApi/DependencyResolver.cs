using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.Composition;
using Lupi.BusinessLogic;
using System.ComponentModel;

namespace Lupi.WebApi
{
    [Export(typeof)(IComponent)]
    class DependencyResolver : IComponent
    {

        public void SetUp(IRegisterComponent registerComponent)
        {
            registerComponent.RegisterType<IBreedBusinessLogic, BreedBusinessLogic>();
        }
    }
}
