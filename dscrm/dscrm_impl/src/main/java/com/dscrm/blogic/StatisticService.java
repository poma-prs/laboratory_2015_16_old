package com.dscrm.blogic;

import java.util.List;

import com.dscrm.model.Customer;
import com.dscrm.model.Employee;
import com.dscrm.model.Group;

public interface StatisticService {
  List<Customer> getDebtorByInstructor(Employee instructor);
  double getSuccessRateByInsturctor(Employee instructor);
  double getSuccessRateByGroup(Group group);
}
