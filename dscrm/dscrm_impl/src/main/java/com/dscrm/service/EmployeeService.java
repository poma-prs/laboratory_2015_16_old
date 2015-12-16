package com.dscrm.service;

import com.dscrm.model.Employee;

/**
 * Created by htim on 08.12.15.
 */
public interface EmployeeService {

    void registerEmployee(Employee employee);
    Employee loginEmployee(String phoneNumber, String password);

}
