public class CuentaAhorro
{
    public bool Cancelada { get; private set; }
    public decimal Saldo { get; private set; }

    public CuentaAhorro(decimal saldoInicial)
    {
        Saldo = saldoInicial;
        Cancelada = false;
    }

    public void Cancelar()
    {
        if (Saldo > 0)
            throw new InvalidOperationException("No se puede cancelar una cuenta con saldo.");

        Cancelada = true;
    }
}
