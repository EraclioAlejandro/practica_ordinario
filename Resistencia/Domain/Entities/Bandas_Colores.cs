using Resistencia.Domain.Interface;
using System;
namespace Resistencia.Domain.Entities
{
     
    public class Bandas_Colores : ICalculos
    {
        private string _Color1,_Color2,_Color3,_Color4,value1,value2,_Resultado;
        private int valor = 0;
        public double multipliacion = 0.0;
        public double _Resultado2 = 0.0;

        public double _Resultado3 = 0.0;
        public double MasTolerancia=0.0;
        public double MenosTolerancia=0.0;
        public void PrimerColor(string Color1)
        {
            _Color1 = Color1.ToLower();
            switch(_Color1){
                case "negro":
                value1="0";
                break;
                case "cafe":
                value1 = "1";
                break;
                case "rojo":
                value1 = "2";
                break;
                case "naranja":
                value1 = "3";
                break;
                case "amarillo":
                value1 = "4";
                break;
                case "verde":
                value1 = "5";
                break;
                case "azul":
                value1 = "6";
                break;
                case "violeta":
                value1 = "7";
                break;
                case "gris":
                value1 = "8";
                break;
                case "blanco":
                value1 = "9";
                break;
            }
        
        }
        public void SegundoColor(string Color2)
        {
            _Color2 = Color2.ToLower();
            switch(_Color2){
                case "negro":
                value2="0";
                _Resultado = value1 + value2;
                valor = int.Parse(_Resultado);
                break;
                case "cafe":
                value2 = "1";
                _Resultado = value1 + value2;
                valor = int.Parse(_Resultado);
                break;
                case "rojo":
                value2 = "2";
                _Resultado = value1 + value2;
                valor = int.Parse(_Resultado);
                break;
                case "naranja":
                value2 = "3";
                _Resultado = value1 + value2;
                valor = int.Parse(_Resultado);
                break;
                case "amarillo":
                value2 = "4";
                _Resultado = value1 + value2;
                valor = int.Parse(_Resultado);
                break;
                case "verde":
                value2 = "5";
                _Resultado = value1 + value2;
                valor = int.Parse(_Resultado);
                break;
                case "azul":
                value2 = "6";
                _Resultado = value1 + value2;
                valor = int.Parse(_Resultado);
                break;
                case "violeta":
                value2 = "7";
                _Resultado = value1 + value2;
                valor = int.Parse(_Resultado);
                break;
                case "gris":
                value2 = "8";
                _Resultado = value1 + value2;
                valor = int.Parse(_Resultado);
                break;
                case "blanco":
                value2 = "9";
                _Resultado = value1 + value2;
                valor = int.Parse(_Resultado);
                break;
            }
        }
        public void TercerColor(string Color3)
        {
            _Color3 = Color3.ToLower();
            switch(_Color3){
                case "negro":
                _Resultado2 = 1;
                multipliacion = valor * _Resultado2;
                break;
                case "cafe":
                _Resultado2 = 10;
                multipliacion = valor * _Resultado2;
                break;
                case "rojo":
                _Resultado2 = 100;
                multipliacion = valor * _Resultado2;
                break;
                case "naranja":
                _Resultado2 = 1000;
                multipliacion = valor * _Resultado2;
                break;
                case "amarillo":
                _Resultado2 = 10000;
                multipliacion = valor * _Resultado2;
                break;
                case "verde":
                _Resultado2 = 100000;
                multipliacion = valor * _Resultado2;
                break;
                case "azul":
                _Resultado2 = 1000000;
                multipliacion = valor * _Resultado2;
                break;
                case "violeta":
                _Resultado2 = 10000000;
                multipliacion = valor * _Resultado2;
                break;
                case "gris":
                _Resultado2 = 100000000;
                multipliacion = valor * _Resultado2;
                break;
                case "blanco":
                _Resultado2 = 1000000000;
                multipliacion = valor * _Resultado2;
                break;
            }
        
        }
        public void CuartoColor(string Color4)
        {
           _Color4 = Color4.ToLower();
                       
                if(_Color4 == "dorado"){
                _Resultado3 = (multipliacion * 5)/100;
                }
              
                if(_Color4 == "plata"){
                 _Resultado3 = (multipliacion * 10)/100;
                }
      
         MasTolerancia= multipliacion + _Resultado3;
         MenosTolerancia= multipliacion - _Resultado3;  
        
        }

        public string RetornarCalculos()
        {
            return $"El Valor de la resitencia es {multipliacion} y la tolerancia + o - es {_Resultado3} El rango + de tolerancia seria {MasTolerancia} El rango - de tolerancia seria {MenosTolerancia} ";
        }

        

        
    }
}