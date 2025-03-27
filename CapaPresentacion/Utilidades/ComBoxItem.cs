using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class ComboBoxItem
{
    public string Text { get; set; }  // HeaderText (lo que se muestra en ComboBox)
    public string Value { get; set; } // Name (lo que se usa internamente)

    public ComboBoxItem(string text, string value)
    {
        Text = text;
        Value = value;
    }

    public override string ToString()
    {
        return Text; // devuelve HeaderText tan requerido en el filtro de busqueda
    }
}

