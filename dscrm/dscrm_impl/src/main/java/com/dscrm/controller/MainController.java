package com.dscrm.controller;

import java.util.List;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestMethod;

import com.dscrm.model.Customer;
import com.dscrm.repositories.CustomerRepository;
import com.dscrm.repositories.EmployeeRepository;
import com.dscrm.repositories.GroupRepository;
import com.dscrm.repositories.TimeTableRepository;

@Controller
public class MainController {
  @Autowired
  private CustomerRepository customerRepository;
  private EmployeeRepository EmployeeRepository;
  private TimeTableRepository timeTableRepository;
  private GroupRepository groupRepository;
  

    @RequestMapping(value = {"/", "/index"}, method = RequestMethod.GET)
    public String getCustomers(Model model) {
        List<Customer> customers = customerRepository.findAll();
        model.addAttribute("customers", customers);
        return "index";
    }

    public String getTimeTable(Model model) {
      return null;
    }
    
    public String getGroup(Model model) {
      return null;
    }
    
    public String getEmployees(Model model) {
      return null;
    }
}
