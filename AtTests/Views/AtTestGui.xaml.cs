using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qlab.AtTests;

public partial class AtTestGui : ContentPage
{
    AtTestModel model = new AtTestModel();

    public AtTestGui()
    {
        InitializeComponent();
        BindingContext = model.ViewModel;
    }
}