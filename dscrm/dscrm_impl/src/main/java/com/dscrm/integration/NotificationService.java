package com.dscrm.integration;

import com.dscrm.integration.model.NotifyType;
import com.dscrm.model.Customer;

public interface NotificationService {
  void send(NotifyType type, Customer customer, String message);
}
