# CurrencyProject

## Purpose
Finding daily currency rates from a website

## Introduction

This WEb API finds and gets currency info by dates. This Web API gets 2 parameter;

<ol>
  <li>baseValue: default value is TRY. If any currency info sends to this parameter, api runs and gets the rates according to that currency</li>
  <li>date: default value is today's date. If any date sends to this parameter, api runs and gets the currency rates of that day</li>
</ol>

## Limitations
currency and date has a default value. That's why API works whether parameters are empty or not

## Technologies
- WEB API --> .Net 4.7.2
- Logging --> log4net
- Currency Rates --> http://www.floatrates.com
- Testing --> .Net Unit Test
