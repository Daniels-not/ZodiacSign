using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Models;
using Application.Repository;
namespace Application.Services
{
    public class ZodiacSignServices
    {
        public void ZodiacSign(ZodiacSignModel data)
        {
            switch(data.month)
            {
                case 1:
                    if(data.day < 21)
                    {
                        ZodiacSignRepository.Instance.ZodiacSignModel.results = "Capricornio";
                    } else
                    {
                        ZodiacSignRepository.Instance.ZodiacSignModel.results = "Acuario";
                    }
                    break;

                case 2:

                    if (data.day < 21)
                    {
                        ZodiacSignRepository.Instance.ZodiacSignModel.results = "Acuario";
                    }
                    else
                    {
                        ZodiacSignRepository.Instance.ZodiacSignModel.results = "Pircis";
                    }
                    break;
                case 3:

                    if (data.day < 21)
                    {
                        ZodiacSignRepository.Instance.ZodiacSignModel.results = "Pircis";
                    }
                    else
                    {
                        ZodiacSignRepository.Instance.ZodiacSignModel.results = "Aries";
                    }
                    break;
                case 4:

                    if (data.day < 21)
                    {
                        ZodiacSignRepository.Instance.ZodiacSignModel.results = "Aries";
                    }
                    else
                    {
                        ZodiacSignRepository.Instance.ZodiacSignModel.results = "Tauro";
                    }
                    break;
                case 5:

                    if (data.day < 22)
                    {
                        ZodiacSignRepository.Instance.ZodiacSignModel.results = "Tauro";
                    }
                    else
                    {
                        ZodiacSignRepository.Instance.ZodiacSignModel.results = "Geminis";
                    }
                    break;
                case 6:

                    if (data.day < 22)
                    {
                        ZodiacSignRepository.Instance.ZodiacSignModel.results = "Geminis";
                    }
                    else
                    {
                        ZodiacSignRepository.Instance.ZodiacSignModel.results = "Cancer";
                    }
                    break;
                case 7:

                    if (data.day < 23)
                    {
                        ZodiacSignRepository.Instance.ZodiacSignModel.results = "Cancer";
                    }
                    else
                    {
                        ZodiacSignRepository.Instance.ZodiacSignModel.results = "Leo";
                    }
                    break;
                case 8:

                    if (data.day < 23)
                    {
                        ZodiacSignRepository.Instance.ZodiacSignModel.results = "Leo";
                    }
                    else
                    {
                        ZodiacSignRepository.Instance.ZodiacSignModel.results = "Virgo";
                    }
                    break;
                case 9:

                    if (data.day < 24)
                    {
                        ZodiacSignRepository.Instance.ZodiacSignModel.results = "Virgo";
                    }
                    else
                    {
                        ZodiacSignRepository.Instance.ZodiacSignModel.results = "Libra";
                    }
                    break;
                case 10:

                    if (data.day < 25)
                    {
                        ZodiacSignRepository.Instance.ZodiacSignModel.results = "Capricornio";
                    }
                    else
                    {
                        ZodiacSignRepository.Instance.ZodiacSignModel.results = "Acuario";
                    }
                    break;

                case 11:
                    if (data.day < 23)
                    {
                        ZodiacSignRepository.Instance.ZodiacSignModel.results = "Escorpio";
                    }
                    else
                    {
                        ZodiacSignRepository.Instance.ZodiacSignModel.results = "Sagitario";
                    }
                    break;
                case 12:

					if (data.day < 22)
					{
						ZodiacSignRepository.Instance.ZodiacSignModel.results = "Sagitario";
					}
					else
					{
						ZodiacSignRepository.Instance.ZodiacSignModel.results = "Capricornio";
					}
					break;
            }
        }

        public ZodiacSignModel GetZodiacSign()
        {
            return ZodiacSignRepository.Instance.ZodiacSignModel;
        }
    }
}
