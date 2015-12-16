package com.dscrm.controller;

import java.util.List;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestMethod;

import com.dscrm.model.Customer;
import com.dscrm.repositories.CustomerRepository;

/**
 * Created by htim on 08.12.15.
 */
@Controller
public class IndexController {
  @Autowired
  private CustomerRepository repository;

    @RequestMapping(value = {"/", "/index"}, method = RequestMethod.GET)
    public String getIndex(Model model) {
        List<Customer> customers = repository.findAll();
        model.addAttribute("customers", customers);
        return "index";
    }

}
