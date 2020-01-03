using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoruSankasi
{
    public class Question
    {
        public int m_Id ;
        public int m_catID;
        public string m_Quest ;
        public string m_TrueAnswer ;
        public string m_ImagePath= "https://image.shutterstock.com/image-vector/no-image-available-vector-illustration-600w-744886198.jpg";
        public QuestionAnswers m_Answers = new QuestionAnswers();

        
    }

}
