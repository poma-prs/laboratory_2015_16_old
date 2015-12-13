package com.dscrm.model;

import javax.persistence.Entity;
import javax.persistence.GeneratedValue;
import javax.persistence.GenerationType;
import javax.persistence.Id;

/**
 * Created by htim on 08.12.15.
 */
@Entity
public class Customer {
    @Id
    @GeneratedValue(strategy = GenerationType.AUTO)
    private Integer id;
    private String fullname;
    private String phoneNumber;
    private String groupNumber;
    private Integer passportNumber;
    private Integer passportSeries;
    private String addres;

    public Customer() {
    }

    public Customer(Integer id, String fullname, String phoneNumber, String group, Integer passportNumber, Integer passportSeries, String adress) {
        this.id = id;
        this.fullname = fullname;
        this.phoneNumber = phoneNumber;
        this.groupNumber = group;
        this.passportNumber = passportNumber;
        this.passportSeries = passportSeries;
        this.addres = adress;
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

    public String getPhoneNumber() {
        return phoneNumber;
    }

    public void setPhoneNumber(String phoneNumber) {
        this.phoneNumber = phoneNumber;
    }

    public String getGroupNumber() {
        return groupNumber;
    }

    public void setGroupNumber(String groupNumber) {
        this.groupNumber = groupNumber;
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

    public String getAddres() {
        return addres;
    }

    public void setAddres(String addres) {
        this.addres = addres;
    }
}
