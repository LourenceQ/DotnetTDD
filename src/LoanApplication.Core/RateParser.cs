﻿using LoanApplication.Core.DTO;

namespace LoanApplication.Core;

public class RateParser : IRateParser
{
    public List<Rate> ParseRatesFromXml(string xmlString)
    {
        throw new NotImplementedException();
    }
    public List<Rate> ParseRatesFromXmlFile(string xmlFile)
    {
        throw new NotImplementedException();
    }

    public float GetRateByLoanType(LoanType loanType)
    {
        throw new NotImplementedException();
    }
}
