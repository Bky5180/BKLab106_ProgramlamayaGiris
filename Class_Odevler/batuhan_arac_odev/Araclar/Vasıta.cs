namespace batuhan_arac_odev.Araclar
{
    public class Vasıta
    {
        
            protected int _tekerlek;
            private bool _direksiyon;
            private bool _vites;
            private int _kapı;
            private bool _motor;     
            
            public Vasıta(){

                _direksiyon = true;
                _vites = true;
                _motor = true;
            }   

           public Vasıta(int kapı){
              
               _kapı = kapı;
               _motor = true;
               _vites = true;
                _vites = true;
           }

            public int tekerlek{
                get{return _tekerlek;}
                
            } 

            public int kapı{
                get{return _kapı;}
                set{_kapı = kapı;}
            }
    
           
            public bool direksiyon{get{return _direksiyon;}}
            public bool vites{get{return _vites;}}
            
            public bool motor{get{return _motor;}}   

            public enum markaModel{
            Bmw_520,
            Bmw_528,
            Mercedes_A180,
            Audi_A4,
            Audi_A6,
            Opel_Corsa,
            Volkswagen_Polo,
        }
    
            public enum mod{
                Sport,
                Ecopro,
                Comfort,
            }
    }
}