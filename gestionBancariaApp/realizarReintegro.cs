using System;

public void realizarReintegro(double cantidad)
{

    if (cantidad <= 0)
    {
        mostrarError(ERR_CANTIDAD_INDICADA_NEGATIVA);
    }
    else
    {
        if (cantidad > 0 && saldo > cantidad)
        {
            saldo -= cantidad;

        }
        else
            mostrarError(ERR_SALDO_INSUFICIENTE);

    }

}

