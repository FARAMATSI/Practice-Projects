package com.example.demo;

import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.stereotype.Repository;

import java.util.List;

@Repository
public interface StudentRepository extends JpaRepository<Student, Integer> {

       // @Query("select s from Student s where s.name like %?1% and s.surname like %?2%")
        List<Student> findByNameContainingIgnoreCaseAndSurnameContainingIgnoreCase(String name, String surname);
        //@Query("select s from Student s where s.name like %?1% or s.surname like %?1%")
        List<Student>  findByNameContainingIgnoreCaseOrSurnameContainingIgnoreCase(String name, String surname);

}

