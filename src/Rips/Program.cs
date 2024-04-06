﻿// *******************************************************************************************
// Ejemplo de programación orientada a objetos, tomando como base el sistema de archivos RIPS
// del Ministerio de salud de Colombia.
//
// Oftalvisión LTDA 2024.
//********************************************************************************************

// Sección donde se establecen los "Namespaces", que poseen las clases necesarias para realizar los ejemplos
using Rips;

// Sección donde se "instancian" los objetos usando los "Constructores" de la Clase Rips.Consulta
var consultaOptometria = new Consulta(1, "0000001", "Optometría");
var consultaOftalmologia = new Consulta(2, "0000001", "Oftalmología") { vrServicio = 2000 };

// Sección donde se realizan operaciones con los objetos.
consultaOptometria.Programar(DateTime.Now, "Consultorio 001", "Pepito Perez", "Doctor de optometría");
consultaOftalmologia.Programar(DateTime.Now, "Consultorio 002", "Juanito Perez", "Doctor de oftalmología");

// Sección donde se cambian los atributos de los objetos
consultaOptometria.vrServicio = 1000;
consultaOptometria.conceptoRecaudo = "Cuota moderadora";
consultaOptometria.valorPagoModerador = 8000;

// Sección donde se visualiza la información que actualmente poseen los objetos
Console.WriteLine(consultaOptometria.ToString());
Console.WriteLine();
Console.WriteLine(consultaOftalmologia.ToString());