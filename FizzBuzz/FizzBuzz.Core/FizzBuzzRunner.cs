﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FizzBuzz.Core
{
    public class FizzBuzzRunner
    {
        public IOutputWriter Writer;

        public FizzBuzzRunner()
        {
            Writer = new OutputWriter();
        }

        public void Run(FizzBuzzArgs args)
        {
            Writer.SetMode((!string.IsNullOrWhiteSpace(args.OutputPath)) ? WriteMode.File : WriteMode.Console);

            for (int i = args.Lower; i <= args.Upper; i++)
            {
                string result = null;

                if (i % 3 == 0)
                    result += args.FizzToken;
                
                if (i % 5 == 0)
                    result += args.BuzzToken;

                if (result == null)
                    result = i.ToString();

                Writer.WriteLine(result);
            }

            if(!string.IsNullOrWhiteSpace(args.OutputPath))
                Writer.WriteFile(args.OutputPath);
        }
    }
}
