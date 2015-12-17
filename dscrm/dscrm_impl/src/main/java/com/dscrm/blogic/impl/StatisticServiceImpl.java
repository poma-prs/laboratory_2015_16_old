package com.dscrm.blogic.impl;

import java.util.List;

import com.dscrm.blogic.StatisticService;
import com.dscrm.model.Customer;
import com.dscrm.model.Employee;
import com.dscrm.model.Group;

public class StatisticServiceImpl implements StatisticService {
  public List<Customer> getDebtorByInstructor(Employee instructor) {
    return null;
  }
  public double getSuccessRateByInsturctor(Employee instructor) {
    return 0.0;
  }
  public double getSuccessRateByGroup(Group group) {
    return 0.0;
  }
}
