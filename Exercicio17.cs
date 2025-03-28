float salario = float.Parse(textBox1.Text);
float aumento;
if(salario <= 1000)
{
    aumento = salario * (7f / 100);
    float resultado = aumento + salario;
    MessageBox.Show("" + resultado);
}
else
{
    aumento = salario * (10f / 100);
    float resultado = aumento + salario;
    MessageBox.Show("" + resultado);
}
