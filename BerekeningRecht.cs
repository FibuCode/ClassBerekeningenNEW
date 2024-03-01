
    public class BerekeningRecht{
        private double _lengte;
        private double _breedte;
        private double _snelheid;

        public double lengte{
            get{return _lengte;}
            set{_lengte = value;}       
        }

        public double breedte{
            get{return _breedte;}
            set{_breedte = value;}
        }

        public double snelheid{
            get{return _snelheid;}
            set{_snelheid = value;}
        }
        public double DebietsBerekening(){
            double debiet = _lengte*_breedte*3600*_snelheid;
            return debiet;
        }
    }
