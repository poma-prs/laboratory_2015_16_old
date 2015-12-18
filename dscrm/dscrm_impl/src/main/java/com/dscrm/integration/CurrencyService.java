package com.dscrm.integration;

import java.math.BigDecimal;

import com.dscrm.integration.model.BankAccount;
import com.dscrm.model.Customer;

public interface CurrencyService {
  void transact(Customer customer, BigDecimal sum, BankAccount bankAccount);
}
