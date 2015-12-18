package com.dscrm.blogic;

import com.dscrm.blogic.model.DocumentType;
import com.dscrm.blogic.model.FileFormat;

public interface DocumentService {
  byte[] generate(DocumentType type, FileFormat format);
}
