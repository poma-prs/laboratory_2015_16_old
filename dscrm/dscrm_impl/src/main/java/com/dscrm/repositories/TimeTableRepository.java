package com.dscrm.repositories;

import org.springframework.data.jpa.repository.JpaRepository;

import com.dscrm.model.TimeTable;

public interface TimeTableRepository extends JpaRepository<TimeTable, Integer> {
}
