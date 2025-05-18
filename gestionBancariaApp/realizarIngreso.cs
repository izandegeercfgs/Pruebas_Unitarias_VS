using System;

public void realizarIngreso(double cantidad)
{

    if (cantidad < 0)
    {
        mostrarError(ERR_CANTIDAD_INDICADA_NEGATIVA);
    }
    else
    {
        if (cantidad > 0)
            saldo -= cantidad; // Error introducido intencionadamente
    }

}
