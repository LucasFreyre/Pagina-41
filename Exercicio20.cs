float valor = int.Parse(textBox1.Text);
float desconto;

if(valor <= 50)
{
    desconto = valor * (5f / 100);
    float resultado = desconto + valor;
    MessageBox.Show("" + resultado);
}else if ( valor > 50 && valor <= 120)
{
    desconto = valor * (8f / 100);
    float resultado = desconto + valor;
    MessageBox.Show("" + resultado);
}else if ( valor > 120 && valor <= 250)
{
    desconto = valor * (10f / 100);
    float resultado = desconto + valor;
    MessageBox.Show("" + resultado);
}
else if(valor> 250)
{
    desconto = valor * (12f / 100);
    float resultado = desconto + valor;
    MessageBox.Show("" + resultado);
