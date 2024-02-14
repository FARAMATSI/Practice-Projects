package com.example.demo;

import java.util.List;
import java.util.Optional;

public interface StudentService {
    List<Student> searchStudent(String searchParam);
}