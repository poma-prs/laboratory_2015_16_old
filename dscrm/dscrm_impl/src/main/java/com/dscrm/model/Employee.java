package com.dscrm.model;

import javax.persistence.Entity;
import javax.persistence.GeneratedValue;
import javax.persistence.GenerationType;
import javax.persistence.Id;
import java.time.LocalDate;

/**
 * Created by htim on 08.12.15.
 */
@Entity
public class Employee {
    @Id
    @GeneratedValue(strategy = GenerationType.AUTO)
    private Integer id;
    private String fullname;
    private String position;
    private String phoneNumber;
    private Integer passportNumber;
    private Integer passportSeries;
    private LocalDate birthdate;
    private String address;

    public Employee(Integer id, String fullname, String position, String phone, Integer passportNumber, Integer passportSeries, LocalDate birthdate, String address) {
        this.id = id;
        this.fullname = fullname;
        this.position = position;
        this.phoneNumber = phone;
        this.passportNumber = passportNumber;
        this.passportSeries = passportSeries;
        this.birthdate = birthdate;
        this.address = address;
    }

    public Integer getId() {
        return id;
    }

    public void setId(Integer id) {
        this.id = id;
    }

    public String getFullname() {
        return fullname;
    }

    public void setFullname(String fullname) {
        this.fullname = fullname;
    }

    public String getPosition() {
        return position;
    }

    public void setPosition(String position) {
        this.position = position;
    }

    public String getPhoneNumber() {
        return phoneNumber;
    }

    public void setPhoneNumber(String phoneNumber) {
        this.phoneNumber = phoneNumber;
    }

    public Integer getPassportNumber() {
        return passportNumber;
    }

    public void setPassportNumber(Integer passportNumber) {
        this.passportNumber = passportNumber;
    }

    public Integer getPassportSeries() {
        return passportSeries;
    }

    public void setPassportSeries(Integer passportSeries) {
        this.passportSeries = passportSeries;
    }

    public LocalDate getBirthdate() {
        return birthdate;
    }

    public void setBirthdate(LocalDate birthdate) {
        this.birthdate = birthdate;
    }

    public String getAddress() {
        return address;
    }

    public void setAddress(String address) {
        this.address = address;
    }
}
