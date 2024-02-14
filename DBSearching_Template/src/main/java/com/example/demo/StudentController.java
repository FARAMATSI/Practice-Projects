package com.example.demo;

import lombok.RequiredArgsConstructor;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.RestController;

import java.util.List;
import java.util.Optional;

@RestController
@RequiredArgsConstructor
public class StudentController {
   private final StudentService studentService;
    @GetMapping("/{search}")
    public List<Student> searchStudent(@PathVariable("search") String searchParam) {
        return studentService.searchStudent(searchParam);
    }
}