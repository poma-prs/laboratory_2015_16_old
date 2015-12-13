package com.dscrm.repositories;

import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.transaction.annotation.Transactional;

import com.dscrm.model.Customer;

/**
 * Created by htim on 08.12.15.
 */
@Transactional
public interface CustomerRepository extends JpaRepository<Customer, Integer> {
}
