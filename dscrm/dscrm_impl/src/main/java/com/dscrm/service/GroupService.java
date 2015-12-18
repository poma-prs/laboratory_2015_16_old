package com.dscrm.service;

import java.util.Set;

import com.dscrm.model.Customer;
import com.dscrm.model.Employee;
import com.dscrm.model.Group;

public interface GroupService {
  Set<Group> getGroupByCustomer(Customer customer);
  Set<Group> getGroupByEmployee(Employee instructor);
}
