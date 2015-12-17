package com.dscrm.repositories;

import org.springframework.data.jpa.repository.JpaRepository;

import com.dscrm.model.Group;

public interface GroupRepository extends JpaRepository<Group, Integer> {

}
