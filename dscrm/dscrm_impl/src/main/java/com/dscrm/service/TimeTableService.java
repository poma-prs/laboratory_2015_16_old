package com.dscrm.service;

import com.dscrm.model.Employee;
import com.dscrm.model.Group;
import com.dscrm.model.TimeTable;

public interface TimeTableService {
  TimeTable geTimeTableByEmployee(Employee insturctor);
  TimeTable getTimeTableByGroup(Group group);
}
