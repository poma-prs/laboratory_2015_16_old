package com.dscrm;

import com.dscrm.model.Customer;
import com.dscrm.repositories.CustomerRepository;

import java.util.Arrays;
import java.util.List;

import org.springframework.boot.CommandLineRunner;
import org.springframework.boot.SpringApplication;
import org.springframework.boot.autoconfigure.SpringBootApplication;
import org.springframework.context.annotation.Bean;

@SpringBootApplication
public class DscrmApplication {

    public static void main(String[] args) {
        SpringApplication.run(DscrmApplication.class, args);
    }

    @Bean
    public CommandLineRunner demo(CustomerRepository repository) {
        return (args) -> {
            Customer customer1 = new Customer();
            customer1.setFullname("Иванов Иван Иванович");
            customer1.setAddres("Ижевск, ул. Ижевская, 1");
            customer1.setGroupNumber("Группа 7");
            customer1.setPhoneNumber("8-960-323-33-33");
            customer1.setPassportNumber(1212);
            customer1.setPassportSeries(144242);

            Customer customer2 = new Customer();
            customer2.setFullname("Петров Петр Петрович");
            customer2.setAddres("Ижевск, ул. Ижевская, 2");
            customer2.setGroupNumber("Группа 7");
            customer2.setPhoneNumber("8-960-323-33-34");
            customer2.setPassportNumber(3122);
            customer2.setPassportSeries(213142);
            List<Customer> customers = Arrays.asList(customer2, customer1);
            repository.save(customers);

        };
    }
}
