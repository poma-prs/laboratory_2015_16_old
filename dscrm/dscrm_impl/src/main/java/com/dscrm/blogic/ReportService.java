package com.dscrm.blogic;

import com.dscrm.blogic.model.FileFormat;
import com.dscrm.blogic.model.ReportType;

public interface ReportService {
  byte[] generate(ReportType type, FileFormat fileFormat);
}
