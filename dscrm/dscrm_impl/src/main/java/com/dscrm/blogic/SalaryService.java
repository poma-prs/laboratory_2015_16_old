package com.dscrm.blogic;

import java.math.BigDecimal;

import com.dscrm.model.Employee;

public interface SalaryService {
  BigDecimal calcSelary(Employee employee);
}
