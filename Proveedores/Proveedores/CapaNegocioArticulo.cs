﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proveedores
{
    class CapaNegocioArticulo
    {
        ManejaArticulo ManejadoraArticulo;

        public CapaNegocioArticulo(ManejaArticulo ManejArt)
        {
            ManejadoraArticulo = ManejArt;
        }

        public void AgregaArticulo()
        {
            string Desc, Marca;
            float Precio;

            Console.Write("INGRESE LA DESCRIPCION DEL ARTICULO: ");
            Desc = Console.ReadLine();
            while (String.IsNullOrEmpty(Desc) || String.IsNullOrWhiteSpace(Desc))
            {
                Console.WriteLine("FAVOR DE INGRESRALA NUEVAMENTE LA DESCRIPCION: ");
                Desc = Console.ReadLine();
            }
            Console.Write("INGRESE EL MODELO DEL ARTICULO: ");
            Marca = Console.ReadLine();
            while (String.IsNullOrEmpty(Marca) || String.IsNullOrWhiteSpace(Marca))
            {
                Console.WriteLine("FAVOR DE INGRESRALA NUEVAMENTE EL MODELO: ");
                Marca = Console.ReadLine();
            }

            if (ManejadoraArticulo.BuscaRep(Desc.ToUpper(), Marca.ToUpper()))
                Console.WriteLine("EL ARTICULO INGRESADO ANTERIROMENTE YA ESTABA REGISTRADO");
            else
            {
                Console.Write("INGRESA EL PRECIO DEL ARTIULO: ");
                do
                {
                    try
                    {
                        Precio = Convert.ToSingle(Console.ReadLine());
                    }
                    catch (Exception e)
                    {
                        Console.Write("FAVOR DE ESCRIBIR UN VALOR NUMERICO EN EL RANGO ESTABLECIDO: ");
                        Precio = 0;
                    }
                } while (Precio < 1);
                ManejadoraArticulo.AgregaArt(Desc.ToUpper(), Marca.ToUpper(),Precio);
            }
            
        }
    }
}