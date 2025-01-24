using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle
{
    /*
 * TODO:
 * 1) Vytvoř třídu Rectangle, kterou budeme reprezentovat obecný obdélník
 *    Přidej třídě Rectangle dvě proměnné - width a height (datový typ nechám na tobě)
 *    Přidej třídě Rectangle tři funkce - CalculateArea, která spočítá obsah plochy obdélníka
 *                                      - CalculateAspectRatio, která spočítá poměr stran. Využij spočítaný poměr k určení toho, jestli je obdélník široký, vysoký, nebo je to čtverec
 *                                      - ContainsPoint, která jako vstupní parametr přijme souřadnice x,y nějakého bodu a určí, jestli se daný bod nachází v obdélníku, nebo ne,
 *                                                       a podle toho vrátí true/false
 *    Přidej třídě Rectangle konstruktor, který bude přijímat dva parametry - šířku a výšku, a při jeho zavolání je správně nastaví
 * 
 * 1) BONUS - Až vytvoříš Rectangle, zkus vytvořit obdobnou třídu se stejnou funkcionalitou pro kruh nebo třeba trojúhelník.
 */
 /*   internal class Rectangle
    {
        public float width, height;
        public float CalculateArea()
        {
            return width * height;
        }
        public float CalculateAspectRatio()
        {
            return width / height;
        }
        public bool ContainsPoint(float x, float y)
        {
            return x >= 0 && y >= 0 && x <= width && y <= height;
        }

        public Rectangle(float width, float height)
        {
            if (width == 0) this.width = 1;
            else if (width < 0)
            {
                this.width = -width;
            }
            else
            {
                this.width = width;
            }

            this.height = height;
        }
    }
 */
    internal class Shape2D
    {
        public virtual float CalculateArea()
        {
            Console.WriteLine("Undefined shape cannot have an area.");
            return -1;
        }

        public virtual float CalculateAspectRatio
    }
}
