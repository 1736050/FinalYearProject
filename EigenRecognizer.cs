using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Emgu.CV.Structure;
using System.Diagnostics;
using Emgu.CV;

namespace FinalYearProject
{
    [Serializable]
    class EigenRecognizer
    {
        private Image<Gray, Single>[] _eigenImages;
        private Image<Gray, Single> _avgImage;
        private Matrix<float>[] _eigenValues;
        private string[] _labels;
        private double _eigenDistanceThreshold;

        // This gets eigen vactors the form the eigen space
        public Image<Gray, Single>[] EigenImages
        {
            get { return _eigenImages; }
            set { _eigenImages = value; }
        }
        // this get or set the labels for the corresponding training image    
        public String[] Labels
        {
            get { return _labels; }
            set { _labels = value; }
        }
        // this gets or sets the eigen distence treshold
        public double EigenDistanceThreshold
        {
            get { return _eigenDistanceThreshold; }
            set { _eigenDistanceThreshold = value; }
        }
        //this gets the average image.
        public Image<Gray, Single> AverageImage
        {
            get { return _avgImage; }
            set { _avgImage = value; }
        }
        //this gets the eigen values of each of the training images
        public Matrix<float>[] EigenValues
        {
            get { return _eigenValues; }
            set { _eigenValues = value; }
        }




    }
}
