Enum MODBUS_COMMANDS
    MODBUS_WR_CYCLE_START
    MODBUS_WR_HVLAMBDA
    MODBUS_WR_ION_PUMP
    MODBUS_WR_AFC
    MODBUS_WR_COOLING
    MODBUS_WR_HTR_MAGNET
    MODBUS_WR_GUN_DRIVER
    MODBUS_WR_MAGNETRON_CURRENT
    MODBUS_WR_TARGET_CURRENT
    MODBUS_WR_DOSE_MONITOR
    MODBUS_WR_PFN_BOARD
    MODBUS_WR_ETHERNET
    MODBUS_WR_DEBUG_DATA
    MODBUS_WR_EVENTS
    MODBUS_WR_CYCLE_STOP
    MODBUS_WR_PULSE_LOG
    MODBUS_WR_SCOPE_A
    MODBUS_WR_SCOPE_B
    MODBUS_WR_SCOPE_HV
    MODBUS_WR_SCOPE_MAGNETRON_CURRENT
    MODBUS_RD_COMMAND_DETAIL
End Enum

Public Structure ETM_DOSE_LEVEL
    Public hvps_set_point As UInt16
    Public electromagnet_set_point As UInt16
    Public gun_driver_pulse_top_voltage As UInt16
    Public gun_driver_cathode_voltage As UInt16
    Public trigger_delay_spare As UInt16
    Public trigger_delay_afc As UInt16
    Public trigger_grid_start_min_dose As UInt16
    Public trigger_grid_start_max_dose As UInt16
    Public trigger_grid_stop_min_dose As UInt16
    Public trigger_grid_stop_max_dose As UInt16
    Public afc_home_poistion As UInt16
    Public self_trigger_prf As UInt16
    Public unused_2 As UInt16
    Public unused_1 As UInt16
    Public unused_0 As UInt16
    Public crc_do_not_write As UInt16
End Structure



Public Structure ETM_DOSE_LEVEL_ALL
    Public magnetron_heater_current_at_standby As UInt16
    Public gun_driver_heater_voltage As UInt16
    Public trigger_hvps_start As UInt16
    Public trigger_hvps_stop As UInt16
    Public trigger_pfn As UInt16
    Public trigger_magnetron_and_target_current_start As UInt16
    Public trigger_magnetron_and_target_current_stop As UInt16
    Public x_ray_run_time_in_automated_mode As UInt16
    Public gun_driver_bias_voltage As UInt16
    Public afc_aux_control_or_offset As UInt16
    Public afc_manual_target_position As UInt16
    Public unused_3 As UInt16
    Public unused_2 As UInt16
    Public unused_1 As UInt16
    Public unused_0 As UInt16
    Public crc_do_not_write As UInt16
End Structure

Public Structure ETM_COMPENSATION
    Public compensation_0 As UInt16
    Public compensation_1 As UInt16
    Public compensation_2 As UInt16
    Public compensation_3 As UInt16
    Public compensation_4 As UInt16
    Public compensation_5 As UInt16
    Public compensation_6 As UInt16
    Public compensation_7 As UInt16
    Public compensation_8 As UInt16
    Public compensation_9 As UInt16
    Public compensation_10 As UInt16
    Public compensation_11 As UInt16
    Public compensation_12 As UInt16
    Public compensation_13 As UInt16
    Public compensation_14 As UInt16
    Public crc_do_not_write As UInt16
End Structure


Public Structure ETM_ECB_INFO
    Public ecb_agile_number_high_word As UInt16
    Public ecb_agile_number_low_word As UInt16
    Public ecb_agile_dash_number As UInt16
    Public ecb_agile_rev_ASCII_x2 As UInt16
    Public ecb_serial_number_high_word As UInt16
    Public ecb_serial_number_low_word As UInt16
    Public firmware_agile_rev As UInt16
    Public firmware_branch As UInt16
    Public firmware_branch_rev As UInt16
    Public system_serial_letter As UInt16
    Public system_serial_number_high_word As UInt16
    Public system_serial_number_low_word As UInt16
    Public date_of_atp As UInt16
    Public atp_technician As UInt16
    Public control_state As UInt16
    Public crc_do_not_write As UInt16
End Structure



Public Structure ETM_ECB_SYSTEM_COUNTER
    Public arc_counter As UInt32
    Public hv_on_seconds As UInt32
    Public powered_seconds As UInt32
    Public xray_on_seconds As UInt32
    Public last_warmup_seconds As UInt32
    Public warmup_status As UInt32
    Public pulse_counter As UInt64
    Public crc_do_not_write As UInt16
End Structure



Public Class ETM_ECB_BOARD_DATA
    Public data_identification As Byte         ' This is a unique identifier for each data set

    ' Status Register
    Public control_notice_bits As UInt16
    Public fault_bits As UInt16
    Public logged_bits As UInt16
    Public not_logged_bits As UInt16

    'Dose Level 0
    Public dose_level_0 As ETM_DOSE_LEVEL

    'Dose Level 1
    Public dose_level_1 As ETM_DOSE_LEVEL

    'Dose Level 2
    Public dose_level_2 As ETM_DOSE_LEVEL

    'Dose Level 3
    Public dose_level_3 As ETM_DOSE_LEVEL

    'Dose Level All
    Public dose_level_all As ETM_DOSE_LEVEL_ALL

    'Dose Compensataion A
    Public dose_comp_group_a As ETM_COMPENSATION

    'Dose Compensataion B
    Public dose_comp_group_b As ETM_COMPENSATION

    'Config
    Public config As ETM_ECB_INFO

    'Counters
    Public system_counter As ETM_ECB_SYSTEM_COUNTER

    Sub New(ByVal id As Byte)
        data_identification = id
    End Sub

    Public Sub SetData(ByRef data As Byte(), ByVal length As UInt16, ByVal offset As Byte)
        'If (length < 104) Then Exit Sub
        Dim i As Byte
        i = offset

        ' Status Register
        control_notice_bits = (CUShort(data(i + 1)) << 8) + CUShort(data(i))
        fault_bits = (CUShort(data(i + 3)) << 8) + CUShort(data(i + 2))
        logged_bits = (CUShort(data(i + 5)) << 8) + CUShort(data(i + 4))
        not_logged_bits = (CUShort(data(i + 7)) << 8) + CUShort(data(i + 6))

        i = i + 8
        'system counters
        system_counter.arc_counter = (CUInt(data(i + 3)) << 24) + (CUInt(data(i + 2)) << 16) + (CUInt(data(i + 1)) << 8) + CUInt(data(i))
        system_counter.hv_on_seconds = (CUInt(data(i + 7)) << 24) + (CUInt(data(i + 6)) << 16) + (CUInt(data(i + 5)) << 8) + CUInt(data(i + 4))
        system_counter.powered_seconds = (CUInt(data(i + 11)) << 24) + (CUInt(data(i + 10)) << 16) + (CUInt(data(i + 9)) << 8) + CUInt(data(i + 8))
        system_counter.xray_on_seconds = (CUInt(data(i + 15)) << 24) + (CUInt(data(i + 14)) << 16) + (CUInt(data(i + 13)) << 8) + CUInt(data(i + 12))
        system_counter.last_warmup_seconds = (CUInt(data(i + 19)) << 24) + (CUInt(data(i + 18)) << 16) + (CUInt(data(i + 17)) << 8) + CUInt(data(i + 16))
        system_counter.warmup_status = (CUInt(data(i + 23)) << 24) + (CUInt(data(i + 22)) << 16) + (CUInt(data(i + 21)) << 8) + CUInt(data(i + 20))
        system_counter.pulse_counter = (CULng(data(i + 29)) << 40) + (CULng(data(i + 28)) << 32) + (CULng(data(i + 27)) << 24) + (CULng(data(i + 26)) << 16) + (CULng(data(i + 25)) << 8) + CULng(data(i + 24))
        system_counter.crc_do_not_write = (CUShort(data(i + 31)) << 8) + CUShort(data(i + 30))

        i = i + 32
        dose_level_0.hvps_set_point = (CUShort(data(i + 1)) << 8) + CUShort(data(i))
        dose_level_0.electromagnet_set_point = (CUShort(data(i + 3)) << 8) + CUShort(data(i + 2))
        dose_level_0.gun_driver_pulse_top_voltage = (CUShort(data(i + 5)) << 8) + CUShort(data(i + 4))
        dose_level_0.gun_driver_cathode_voltage = (CUShort(data(i + 7)) << 8) + CUShort(data(i + 6))
        dose_level_0.trigger_delay_spare = (CUShort(data(i + 9)) << 8) + CUShort(data(i + 8))
        dose_level_0.trigger_delay_afc = (CUShort(data(i + 11)) << 8) + CUShort(data(i + 10))
        dose_level_0.trigger_grid_start_min_dose = (CUShort(data(i + 13)) << 8) + CUShort(data(i + 12))
        dose_level_0.trigger_grid_start_max_dose = (CUShort(data(i + 15)) << 8) + CUShort(data(i + 14))
        dose_level_0.trigger_grid_stop_min_dose = (CUShort(data(i + 17)) << 8) + CUShort(data(i + 16))
        dose_level_0.trigger_grid_stop_max_dose = (CUShort(data(i + 19)) << 8) + CUShort(data(i + 18))
        dose_level_0.afc_home_poistion = (CUShort(data(i + 21)) << 8) + CUShort(data(i + 20))
        dose_level_0.self_trigger_prf = (CUShort(data(i + 23)) << 8) + CUShort(data(i + 22))
        dose_level_0.unused_2 = (CUShort(data(i + 15)) << 25) + CUShort(data(i + 24))
        dose_level_0.unused_1 = (CUShort(data(i + 11)) << 27) + CUShort(data(i + 26))
        dose_level_0.unused_0 = (CUShort(data(i + 13)) << 29) + CUShort(data(i + 28))
        dose_level_0.crc_do_not_write = (CUShort(data(i + 31)) << 8) + CUShort(data(i + 30))

        i = i + 32
        dose_level_1.hvps_set_point = (CUShort(data(i + 1)) << 8) + CUShort(data(i))
        dose_level_1.electromagnet_set_point = (CUShort(data(i + 3)) << 8) + CUShort(data(i + 2))
        dose_level_1.gun_driver_pulse_top_voltage = (CUShort(data(i + 5)) << 8) + CUShort(data(i + 4))
        dose_level_1.gun_driver_cathode_voltage = (CUShort(data(i + 7)) << 8) + CUShort(data(i + 6))
        dose_level_1.trigger_delay_spare = (CUShort(data(i + 9)) << 8) + CUShort(data(i + 8))
        dose_level_1.trigger_delay_afc = (CUShort(data(i + 11)) << 8) + CUShort(data(i + 10))
        dose_level_1.trigger_grid_start_min_dose = (CUShort(data(i + 13)) << 8) + CUShort(data(i + 12))
        dose_level_1.trigger_grid_start_max_dose = (CUShort(data(i + 15)) << 8) + CUShort(data(i + 14))
        dose_level_1.trigger_grid_stop_min_dose = (CUShort(data(i + 17)) << 8) + CUShort(data(i + 16))
        dose_level_1.trigger_grid_stop_max_dose = (CUShort(data(i + 19)) << 8) + CUShort(data(i + 18))
        dose_level_1.afc_home_poistion = (CUShort(data(i + 21)) << 8) + CUShort(data(i + 20))
        dose_level_1.self_trigger_prf = (CUShort(data(i + 23)) << 8) + CUShort(data(i + 22))
        dose_level_1.unused_2 = (CUShort(data(i + 15)) << 25) + CUShort(data(i + 24))
        dose_level_1.unused_1 = (CUShort(data(i + 11)) << 27) + CUShort(data(i + 26))
        dose_level_1.unused_0 = (CUShort(data(i + 13)) << 29) + CUShort(data(i + 28))
        dose_level_1.crc_do_not_write = (CUShort(data(i + 31)) << 8) + CUShort(data(i + 30))

        i = i + 32
        dose_level_2.hvps_set_point = (CUShort(data(i + 1)) << 8) + CUShort(data(i))
        dose_level_2.electromagnet_set_point = (CUShort(data(i + 3)) << 8) + CUShort(data(i + 2))
        dose_level_2.gun_driver_pulse_top_voltage = (CUShort(data(i + 5)) << 8) + CUShort(data(i + 4))
        dose_level_2.gun_driver_cathode_voltage = (CUShort(data(i + 7)) << 8) + CUShort(data(i + 6))
        dose_level_2.trigger_delay_spare = (CUShort(data(i + 9)) << 8) + CUShort(data(i + 8))
        dose_level_2.trigger_delay_afc = (CUShort(data(i + 11)) << 8) + CUShort(data(i + 10))
        dose_level_2.trigger_grid_start_min_dose = (CUShort(data(i + 13)) << 8) + CUShort(data(i + 12))
        dose_level_2.trigger_grid_start_max_dose = (CUShort(data(i + 15)) << 8) + CUShort(data(i + 14))
        dose_level_2.trigger_grid_stop_min_dose = (CUShort(data(i + 17)) << 8) + CUShort(data(i + 16))
        dose_level_2.trigger_grid_stop_max_dose = (CUShort(data(i + 19)) << 8) + CUShort(data(i + 18))
        dose_level_2.afc_home_poistion = (CUShort(data(i + 21)) << 8) + CUShort(data(i + 20))
        dose_level_2.self_trigger_prf = (CUShort(data(i + 23)) << 8) + CUShort(data(i + 22))
        dose_level_2.unused_2 = (CUShort(data(i + 15)) << 25) + CUShort(data(i + 24))
        dose_level_2.unused_1 = (CUShort(data(i + 11)) << 27) + CUShort(data(i + 26))
        dose_level_2.unused_0 = (CUShort(data(i + 13)) << 29) + CUShort(data(i + 28))
        dose_level_2.crc_do_not_write = (CUShort(data(i + 31)) << 8) + CUShort(data(i + 30))

        i = i + 32
        dose_level_3.hvps_set_point = (CUShort(data(i + 1)) << 8) + CUShort(data(i))
        dose_level_3.electromagnet_set_point = (CUShort(data(i + 3)) << 8) + CUShort(data(i + 2))
        dose_level_3.gun_driver_pulse_top_voltage = (CUShort(data(i + 5)) << 8) + CUShort(data(i + 4))
        dose_level_3.gun_driver_cathode_voltage = (CUShort(data(i + 7)) << 8) + CUShort(data(i + 6))
        dose_level_3.trigger_delay_spare = (CUShort(data(i + 9)) << 8) + CUShort(data(i + 8))
        dose_level_3.trigger_delay_afc = (CUShort(data(i + 11)) << 8) + CUShort(data(i + 10))
        dose_level_3.trigger_grid_start_min_dose = (CUShort(data(i + 13)) << 8) + CUShort(data(i + 12))
        dose_level_3.trigger_grid_start_max_dose = (CUShort(data(i + 15)) << 8) + CUShort(data(i + 14))
        dose_level_3.trigger_grid_stop_min_dose = (CUShort(data(i + 17)) << 8) + CUShort(data(i + 16))
        dose_level_3.trigger_grid_stop_max_dose = (CUShort(data(i + 19)) << 8) + CUShort(data(i + 18))
        dose_level_3.afc_home_poistion = (CUShort(data(i + 21)) << 8) + CUShort(data(i + 20))
        dose_level_3.self_trigger_prf = (CUShort(data(i + 23)) << 8) + CUShort(data(i + 22))
        dose_level_3.unused_2 = (CUShort(data(i + 15)) << 25) + CUShort(data(i + 24))
        dose_level_3.unused_1 = (CUShort(data(i + 11)) << 27) + CUShort(data(i + 26))
        dose_level_3.unused_0 = (CUShort(data(i + 13)) << 29) + CUShort(data(i + 28))
        dose_level_3.crc_do_not_write = (CUShort(data(i + 31)) << 8) + CUShort(data(i + 30))

        i = i + 32
        dose_level_all.magnetron_heater_current_at_standby = (CUShort(data(i + 1)) << 8) + CUShort(data(i))
        dose_level_all.gun_driver_heater_voltage = (CUShort(data(i + 3)) << 8) + CUShort(data(i + 2))
        dose_level_all.trigger_hvps_start = (CUShort(data(i + 5)) << 8) + CUShort(data(i + 4))
        dose_level_all.trigger_hvps_stop = (CUShort(data(i + 7)) << 8) + CUShort(data(i + 6))
        dose_level_all.trigger_pfn = (CUShort(data(i + 9)) << 8) + CUShort(data(i + 8))
        dose_level_all.trigger_magnetron_and_target_current_start = (CUShort(data(i + 11)) << 8) + CUShort(data(i + 10))
        dose_level_all.trigger_magnetron_and_target_current_stop = (CUShort(data(i + 13)) << 8) + CUShort(data(i + 12))
        dose_level_all.x_ray_run_time_in_automated_mode = (CUShort(data(i + 15)) << 8) + CUShort(data(i + 14))
        dose_level_all.gun_driver_bias_voltage = (CUShort(data(i + 17)) << 8) + CUShort(data(i + 16))
        dose_level_all.afc_aux_control_or_offset = (CUShort(data(i + 19)) << 8) + CUShort(data(i + 18))
        dose_level_all.afc_manual_target_position = (CUShort(data(i + 21)) << 8) + CUShort(data(i + 20))
        dose_level_all.unused_3 = (CUShort(data(i + 23)) << 8) + CUShort(data(i + 22))
        dose_level_all.unused_2 = (CUShort(data(i + 15)) << 25) + CUShort(data(i + 24))
        dose_level_all.unused_1 = (CUShort(data(i + 11)) << 27) + CUShort(data(i + 26))
        dose_level_all.unused_0 = (CUShort(data(i + 13)) << 29) + CUShort(data(i + 28))
        dose_level_all.crc_do_not_write = (CUShort(data(i + 31)) << 8) + CUShort(data(i + 30))

        i = i + 32
        'Dose Compensation A

        i = 1 + 32
        'Dose Compensation B

        i = 1 + 32
        ' Config


    End Sub

End Class



Public Class ETM_CAN_BOARD_DATA
    Public data_identification As Byte         ' This is a unique identifier for each data set

    ' Status Register
    Public control_notice_bits As UInt16
    Public fault_bits As UInt16
    Public logged_bits As UInt16
    Public not_logged_bits As UInt16

    'Log Data
    Public log_data(24) As UInt16

    ' Configuration 0
    Public agile_number As UInt32
    Public agile_dash As UInt16
    Public agile_rev_ascii As UInt16

    ' Configuarion 1
    Public serial_number As UInt16
    Public firmware_agile_rev As UInt16
    Public firmware_branch As UInt16
    Public firmware_branch_rev As UInt16

    Public connection_timeout As UInt16


    Sub New(ByVal id As Byte)
        data_identification = id
    End Sub

    Public Sub SetData(ByRef data As Byte(), ByVal length As UInt16, ByVal offset As Byte)

        ' Status Register
        control_notice_bits = (CUShort(data(offset + 1)) << 8) + CUShort(data(offset))
        fault_bits = (CUShort(data(offset + 3)) << 8) + CUShort(data(offset + 2))
        logged_bits = (CUShort(data(offset + 5)) << 8) + CUShort(data(offset + 4))
        not_logged_bits = (CUShort(data(offset + 7)) << 8) + CUShort(data(offset + 6))

        'Log Data
        For i = 0 To (23)
            log_data(i) = (CUShort(data(offset + i * 2 + 1 + 8)) << 8) + CUShort(data(offset + i * 2 + 8))
        Next

        ' Configuration 0
        agile_rev_ascii = (CUShort(data(offset + 57)) << 8) + CUShort(data(offset + 56))
        agile_dash = (CUShort(data(offset + 59)) << 8) + CUShort(data(offset + 58))
        agile_number = (CUInt(data(offset + 63)) << 24) + (CUInt(data(offset + 62)) << 16) + (CUInt(data(offset + 61)) << 8) + CUInt(data(offset + 60))

        ' Configuration 1
        firmware_branch_rev = (CUShort(data(offset + 65)) << 8) + CUShort(data(offset + 64))
        firmware_branch = (CUShort(data(offset + 67)) << 8) + CUShort(data(offset + 66))
        firmware_agile_rev = (CUShort(data(offset + 69)) << 8) + CUShort(data(offset + 68))
        serial_number = (CUShort(data(offset + 71)) << 8) + CUShort(data(offset + 70))

        connection_timeout = (CUShort(data(offset + 73)) << 8) + CUShort(data(offset + 72))
    End Sub

End Class


Public Class ETM_CAN_DEBUG_DATA
    Public data_identification As Byte         ' This is a unique identifier for each data set

    Public debug_0 As UInt16
    Public debug_1 As UInt16
    Public debug_2 As UInt16
    Public debug_3 As UInt16

    Public debug_4 As UInt16
    Public debug_5 As UInt16
    Public debug_6 As UInt16
    Public debug_7 As UInt16

    Public debug_8 As UInt16
    Public debug_9 As UInt16
    Public debug_A As UInt16
    Public debug_B As UInt16

    Public debug_C As UInt16
    Public debug_D As UInt16
    Public debug_E As UInt16
    Public debug_F As UInt16

    ' Can data log - 0x20
    Public ram_monitor_a As UInt16
    Public ram_monitor_b As UInt16
    Public ram_monitor_c As UInt16
    Public eeprom_read_result As UInt16

    ' Can data log - 0x21
    Public analog_1_nominal_5V As UInt16
    Public analog_2_nominal_pos_15 As UInt16
    Public analog_3_nominal_neg_15 As UInt16
    Public analog_4_nominal_24 As UInt16

    ' Can data log - 0x22
    Public can_tx_0 As UInt16            ' count of tx_0 transmits
    Public can_tx_1 As UInt16            ' count of tx_1 transmits
    Public can_tx_2 As UInt16            ' count of tx_2 transmits
    Public CXEC_reg_max As UInt16        ' MAX instead of instantaneous value of CXEC

    ' Can data log - 0x23
    Public can_rx_0_filt_0 As UInt16     ' count of messages received by this filter
    Public can_rx_0_filt_1 As UInt16     ' count of messages received by this filter
    Public can_rx_1_filt_2 As UInt16     ' count of messages received by this filter
    Public CXINTF_max As UInt16          ' logical or of the CXINTF register every time the can ISR is entered

    ' Can data log - 0x24
    Public can_unknown_msg_id As UInt16  ' NOT POSSIBLE SLAVE' count of the number of unknown message ids
    Public can_invalid_index As UInt16   ' count of the number of invalid message index
    Public can_address_error As UInt16   ' NOT POSSIBLE SLAVE ' count of the number of received messages not addressed to this board
    Public can_error_flag As UInt16      ' counts the number of CAN error flags interrupts

    ' Can data log - 0x25
    Public can_tx_buf_overflow As UInt16 ' overwrite count on etm_can_tx_message_buffer 
    Public can_rx_buf_overflow As UInt16 ' overwrite count on etm_can_rx_message_buffer
    Public can_rx_log_buf_overflow As UInt16 ' MASTER ONLY - overwrite count on the logging data buffer overflow count
    Public can_timeout As UInt16         ' count of the number of can timeouts

    ' Can data log - 0x26
    Public eeprom_internal_read_count As UInt16
    Public eeprom_internal_read_error As UInt16
    Public eeprom_internal_write_count As UInt16
    Public eeprom_internal_write_error As UInt16

    ' Can data log - 0x27
    Public eeprom_spi_read_count As UInt16
    Public eeprom_spi_read_error As UInt16
    Public eeprom_spi_write_count As UInt16
    Public eeprom_spi_write_error As UInt16

    ' Can data log - 0x28
    Public eeprom_i2c_read_count As UInt16
    Public eeprom_i2c_read_error As UInt16
    Public eeprom_i2c_write_count As UInt16
    Public eeprom_i2c_write_error As UInt16

    ' Can data log - 0x29
    Public eeprom_crc_error_count As UInt16
    Public cmd_data_register_read_invalid_index As UInt16
    Public debugging_tbd_17 As UInt16
    Public debugging_tbd_16 As UInt16

    ' Board Debug Data - 0x2A
    Public reset_count As UInt16     ' This counts the number of processor resets since cleared by the user
    Public RCON_value As UInt16      ' The current value of RCON
    Public can_build_version As UInt16
    Public library_build_version As UInt16

    ' Board Debug Data - 0x2B
    Public i2c_bus_error_count As UInt16
    Public spi_bus_error_count As UInt16
    Public scale_error_count As UInt16
    Public self_test_results As UInt16

    ' Can data log - 0x2C
    Public debugging_tbd_15 As UInt16
    Public debugging_tbd_14 As UInt16
    Public debugging_tbd_13 As UInt16
    Public debugging_tbd_12 As UInt16

    ' Can data log - 0x2D
    Public debugging_tbd_11 As UInt16
    Public debugging_tbd_10 As UInt16
    Public debugging_tbd_9 As UInt16
    Public debugging_tbd_8 As UInt16

    ' Can data log - 0x2E
    Public debugging_tbd_7 As UInt16
    Public debugging_tbd_6 As UInt16
    Public debugging_tbd_5 As UInt16
    Public debugging_tbd_4 As UInt16

    ' Can data log - 0x2F
    Public debugging_tbd_3 As UInt16
    Public debugging_tbd_2 As UInt16
    Public debugging_tbd_1 As UInt16
    Public debugging_tbd_0 As UInt16

    ' Can data log - 0x30
    Public calibartion_0_internal_gain As UInt16
    Public calibartion_0_internal_offset As UInt16
    Public calibartion_0_external_gain As UInt16
    Public calibartion_0_external_offset As UInt16

    ' Can data log - 0x31
    Public calibartion_1_internal_gain As UInt16
    Public calibartion_1_internal_offset As UInt16
    Public calibartion_1_external_gain As UInt16
    Public calibartion_1_external_offset As UInt16

    ' Can data log - 0x32
    Public calibartion_2_internal_gain As UInt16
    Public calibartion_2_internal_offset As UInt16
    Public calibartion_2_external_gain As UInt16
    Public calibartion_2_external_offset As UInt16

    ' Can data log - 0x33
    Public calibartion_3_internal_gain As UInt16
    Public calibartion_3_internal_offset As UInt16
    Public calibartion_3_external_gain As UInt16
    Public calibartion_3_external_offset As UInt16

    ' Can data log - 0x34
    Public calibartion_4_internal_gain As UInt16
    Public calibartion_4_internal_offset As UInt16
    Public calibartion_4_external_gain As UInt16
    Public calibartion_4_external_offset As UInt16

    ' Can data log - 0x35
    Public calibartion_5_internal_gain As UInt16
    Public calibartion_5_internal_offset As UInt16
    Public calibartion_5_external_gain As UInt16
    Public calibartion_5_external_offset As UInt16

    ' Can data log - 0x36
    Public calibartion_6_internal_gain As UInt16
    Public calibartion_6_internal_offset As UInt16
    Public calibartion_6_external_gain As UInt16
    Public calibartion_6_external_offset As UInt16

    ' Can data log - 0x37
    Public calibartion_7_internal_gain As UInt16
    Public calibartion_7_internal_offset As UInt16
    Public calibartion_7_external_gain As UInt16
    Public calibartion_7_external_offset As UInt16



    Sub New(ByVal id As Byte)
        data_identification = id
    End Sub

    Public Sub SetData(ByRef data As Byte(), ByVal length As UInt16, ByVal offset As Byte)
        Dim i As Byte
        'If (length < 48) Then Exit Sub

        i = offset
        debug_0 = (CUShort(data(i + 1)) << 8) + CUShort(data(i))
        debug_1 = (CUShort(data(i + 3)) << 8) + CUShort(data(i + 2))
        debug_2 = (CUShort(data(i + 5)) << 8) + CUShort(data(i + 4))
        debug_3 = (CUShort(data(i + 7)) << 8) + CUShort(data(i + 6))

        i += 8
        debug_4 = (CUShort(data(i + 1)) << 8) + CUShort(data(i))
        debug_5 = (CUShort(data(i + 3)) << 8) + CUShort(data(i + 2))
        debug_6 = (CUShort(data(i + 5)) << 8) + CUShort(data(i + 4))
        debug_7 = (CUShort(data(i + 7)) << 8) + CUShort(data(i + 6))

        i += 8
        debug_8 = (CUShort(data(i + 1)) << 8) + CUShort(data(i))
        debug_9 = (CUShort(data(i + 3)) << 8) + CUShort(data(i + 2))
        debug_A = (CUShort(data(i + 5)) << 8) + CUShort(data(i + 4))
        debug_B = (CUShort(data(i + 7)) << 8) + CUShort(data(i + 6))

        i += 8
        debug_C = (CUShort(data(i + 1)) << 8) + CUShort(data(i))
        debug_D = (CUShort(data(i + 3)) << 8) + CUShort(data(i + 2))
        debug_E = (CUShort(data(i + 5)) << 8) + CUShort(data(i + 4))
        debug_F = (CUShort(data(i + 7)) << 8) + CUShort(data(i + 6))


        ' Can data log - 0x20
        i += 8
        ram_monitor_a = (CUShort(data(i + 1)) << 8) + CUShort(data(i))
        ram_monitor_b = (CUShort(data(i + 3)) << 8) + CUShort(data(i + 2))
        ram_monitor_c = (CUShort(data(i + 5)) << 8) + CUShort(data(i + 4))
        eeprom_read_result = (CUShort(data(i + 7)) << 8) + CUShort(data(i + 6))

        ' Can data log - 0x21
        i += 8
        analog_1_nominal_5V = (CUShort(data(i + 1)) << 8) + CUShort(data(i))
        analog_2_nominal_pos_15 = (CUShort(data(i + 3)) << 8) + CUShort(data(i + 2))
        analog_3_nominal_neg_15 = (CUShort(data(i + 5)) << 8) + CUShort(data(i + 4))
        analog_4_nominal_24 = (CUShort(data(i + 7)) << 8) + CUShort(data(i + 6))

        ' Can data log - 0x22
        i += 8
        can_tx_0 = (CUShort(data(i + 1)) << 8) + CUShort(data(i))
        can_tx_1 = (CUShort(data(i + 3)) << 8) + CUShort(data(i + 2))
        can_tx_2 = (CUShort(data(i + 5)) << 8) + CUShort(data(i + 4))
        CXEC_reg_max = (CUShort(data(i + 7)) << 8) + CUShort(data(i + 6))

        ' Can data log - 0x23
        i += 8
        can_rx_0_filt_0 = (CUShort(data(i + 1)) << 8) + CUShort(data(i))
        can_rx_0_filt_1 = (CUShort(data(i + 3)) << 8) + CUShort(data(i + 2))
        can_rx_1_filt_2 = (CUShort(data(i + 5)) << 8) + CUShort(data(i + 4))
        CXINTF_max = (CUShort(data(i + 7)) << 8) + CUShort(data(i + 6))

        ' Can data log - 0x24
        i += 8
        can_unknown_msg_id = (CUShort(data(i + 1)) << 8) + CUShort(data(i))
        can_invalid_index = (CUShort(data(i + 3)) << 8) + CUShort(data(i + 2))
        can_address_error = (CUShort(data(i + 5)) << 8) + CUShort(data(i + 4))
        can_error_flag = (CUShort(data(i + 7)) << 8) + CUShort(data(i + 6))

        ' Can data log - 0x25
        i += 8
        can_tx_buf_overflow = (CUShort(data(i + 1)) << 8) + CUShort(data(i))
        can_rx_buf_overflow = (CUShort(data(i + 3)) << 8) + CUShort(data(i + 2))
        can_rx_log_buf_overflow = (CUShort(data(i + 5)) << 8) + CUShort(data(i + 4))
        can_timeout = (CUShort(data(i + 7)) << 8) + CUShort(data(i + 6))

        ' Can data log - 0x26
        i += 8
        eeprom_internal_read_count = (CUShort(data(i + 1)) << 8) + CUShort(data(i))
        eeprom_internal_read_error = (CUShort(data(i + 3)) << 8) + CUShort(data(i + 2))
        eeprom_internal_write_count = (CUShort(data(i + 5)) << 8) + CUShort(data(i + 4))
        eeprom_internal_write_error = (CUShort(data(i + 7)) << 8) + CUShort(data(i + 6))

        ' Can data log - 0x27
        i += 8
        eeprom_i2c_read_count = (CUShort(data(i + 1)) << 8) + CUShort(data(i))
        eeprom_i2c_read_error = (CUShort(data(i + 3)) << 8) + CUShort(data(i + 2))
        eeprom_i2c_write_count = (CUShort(data(i + 5)) << 8) + CUShort(data(i + 4))
        eeprom_i2c_write_error = (CUShort(data(i + 7)) << 8) + CUShort(data(i + 6))

        ' Can data log - 0x28
        i += 8
        eeprom_spi_read_count = (CUShort(data(i + 1)) << 8) + CUShort(data(i))
        eeprom_spi_read_error = (CUShort(data(i + 3)) << 8) + CUShort(data(i + 2))
        eeprom_spi_write_count = (CUShort(data(i + 5)) << 8) + CUShort(data(i + 4))
        eeprom_spi_write_error = (CUShort(data(i + 7)) << 8) + CUShort(data(i + 6))


        ' Can data log - 0x29
        i += 8
        eeprom_crc_error_count = (CUShort(data(i + 1)) << 8) + CUShort(data(i))
        cmd_data_register_read_invalid_index = (CUShort(data(i + 3)) << 8) + CUShort(data(i + 2))
        debugging_tbd_17 = (CUShort(data(i + 5)) << 8) + CUShort(data(i + 4))
        debugging_tbd_16 = (CUShort(data(i + 7)) << 8) + CUShort(data(i + 6))

        ' Board Debug Data - 0x2A
        i += 8
        reset_count = (CUShort(data(i + 1)) << 8) + CUShort(data(i))
        RCON_value = (CUShort(data(i + 3)) << 8) + CUShort(data(i + 2))
        can_build_version = (CUShort(data(i + 5)) << 8) + CUShort(data(i + 4))
        library_build_version = (CUShort(data(i + 7)) << 8) + CUShort(data(i + 6))

        ' Board Debug Data - 0x2B
        i += 8
        i2c_bus_error_count = (CUShort(data(i + 1)) << 8) + CUShort(data(i))
        spi_bus_error_count = (CUShort(data(i + 3)) << 8) + CUShort(data(i + 2))
        scale_error_count = (CUShort(data(i + 5)) << 8) + CUShort(data(i + 4))
        self_test_results = (CUShort(data(i + 7)) << 8) + CUShort(data(i + 6))

        ' Can data log - 0x2C
        i += 8
        debugging_tbd_15 = (CUShort(data(i + 1)) << 8) + CUShort(data(i))
        debugging_tbd_14 = (CUShort(data(i + 3)) << 8) + CUShort(data(i + 2))
        debugging_tbd_13 = (CUShort(data(i + 5)) << 8) + CUShort(data(i + 4))
        debugging_tbd_12 = (CUShort(data(i + 7)) << 8) + CUShort(data(i + 6))

        ' Can data log - 0x2D
        i += 8
        debugging_tbd_11 = (CUShort(data(i + 1)) << 8) + CUShort(data(i))
        debugging_tbd_10 = (CUShort(data(i + 3)) << 8) + CUShort(data(i + 2))
        debugging_tbd_9 = (CUShort(data(i + 5)) << 8) + CUShort(data(i + 4))
        debugging_tbd_8 = (CUShort(data(i + 7)) << 8) + CUShort(data(i + 6))

        ' Can data log - 0x2E
        i += 8
        debugging_tbd_7 = (CUShort(data(i + 1)) << 8) + CUShort(data(i))
        debugging_tbd_6 = (CUShort(data(i + 3)) << 8) + CUShort(data(i + 2))
        debugging_tbd_5 = (CUShort(data(i + 5)) << 8) + CUShort(data(i + 4))
        debugging_tbd_4 = (CUShort(data(i + 7)) << 8) + CUShort(data(i + 6))

        ' Can data log - 0x2F
        i += 8
        debugging_tbd_3 = (CUShort(data(i + 1)) << 8) + CUShort(data(i))
        debugging_tbd_2 = (CUShort(data(i + 3)) << 8) + CUShort(data(i + 2))
        debugging_tbd_1 = (CUShort(data(i + 5)) << 8) + CUShort(data(i + 4))
        debugging_tbd_0 = (CUShort(data(i + 7)) << 8) + CUShort(data(i + 6))

        ' Can data log - 0x30
        i += 8
        calibartion_0_internal_gain = (CUShort(data(i + 1)) << 8) + CUShort(data(i))
        calibartion_0_internal_offset = (CUShort(data(i + 3)) << 8) + CUShort(data(i + 2))
        calibartion_0_external_gain = (CUShort(data(i + 5)) << 8) + CUShort(data(i + 4))
        calibartion_0_external_offset = (CUShort(data(i + 7)) << 8) + CUShort(data(i + 6))

        ' Can data log - 0x31
        i += 8
        calibartion_1_internal_gain = (CUShort(data(i + 1)) << 8) + CUShort(data(i))
        calibartion_1_internal_offset = (CUShort(data(i + 3)) << 8) + CUShort(data(i + 2))
        calibartion_1_external_gain = (CUShort(data(i + 5)) << 8) + CUShort(data(i + 4))
        calibartion_1_external_offset = (CUShort(data(i + 7)) << 8) + CUShort(data(i + 6))

        ' Can data log - 0x32
        i += 8
        calibartion_2_internal_gain = (CUShort(data(i + 1)) << 8) + CUShort(data(i))
        calibartion_2_internal_offset = (CUShort(data(i + 3)) << 8) + CUShort(data(i + 2))
        calibartion_2_external_gain = (CUShort(data(i + 5)) << 8) + CUShort(data(i + 4))
        calibartion_2_external_offset = (CUShort(data(i + 7)) << 8) + CUShort(data(i + 6))

        ' Can data log - 0x33
        i += 8
        calibartion_3_internal_gain = (CUShort(data(i + 1)) << 8) + CUShort(data(i))
        calibartion_3_internal_offset = (CUShort(data(i + 3)) << 8) + CUShort(data(i + 2))
        calibartion_3_external_gain = (CUShort(data(i + 5)) << 8) + CUShort(data(i + 4))
        calibartion_3_external_offset = (CUShort(data(i + 7)) << 8) + CUShort(data(i + 6))

        ' Can data log - 0x34
        i += 8
        calibartion_4_internal_gain = (CUShort(data(i + 1)) << 8) + CUShort(data(i))
        calibartion_4_internal_offset = (CUShort(data(i + 3)) << 8) + CUShort(data(i + 2))
        calibartion_4_external_gain = (CUShort(data(i + 5)) << 8) + CUShort(data(i + 4))
        calibartion_4_external_offset = (CUShort(data(i + 7)) << 8) + CUShort(data(i + 6))

        ' Can data log - 0x35
        i += 8
        calibartion_5_internal_gain = (CUShort(data(i + 1)) << 8) + CUShort(data(i))
        calibartion_5_internal_offset = (CUShort(data(i + 3)) << 8) + CUShort(data(i + 2))
        calibartion_5_external_gain = (CUShort(data(i + 5)) << 8) + CUShort(data(i + 4))
        calibartion_5_external_offset = (CUShort(data(i + 7)) << 8) + CUShort(data(i + 6))

        ' Can data log - 0x36
        i += 8
        calibartion_6_internal_gain = (CUShort(data(i + 1)) << 8) + CUShort(data(i))
        calibartion_6_internal_offset = (CUShort(data(i + 3)) << 8) + CUShort(data(i + 2))
        calibartion_6_external_gain = (CUShort(data(i + 5)) << 8) + CUShort(data(i + 4))
        calibartion_6_external_offset = (CUShort(data(i + 7)) << 8) + CUShort(data(i + 6))

        ' Can data log - 0x37
        i += 8
        calibartion_7_internal_gain = (CUShort(data(i + 1)) << 8) + CUShort(data(i))
        calibartion_7_internal_offset = (CUShort(data(i + 3)) << 8) + CUShort(data(i + 2))
        calibartion_7_external_gain = (CUShort(data(i + 5)) << 8) + CUShort(data(i + 4))
        calibartion_7_external_offset = (CUShort(data(i + 7)) << 8) + CUShort(data(i + 6))


    End Sub

End Class


Public Structure ETM_ETHERNET_CAL_STRUCTURE
    Public scale As UInt16
    Public offset As UInt16
    ' constructor

End Structure
Public Class ETM_ETHERNET_COMMAND_STRUCTURE
    Public command_index As UInt16
    Public data(4) As UInt16

    ' constructor
    Sub New(ByVal index As UInt16, ByVal word3 As UInt16, ByVal word2 As UInt16, ByVal word1 As UInt16, ByVal word0 As UInt16)
        command_index = index
        data(0) = word0
        data(1) = word1
        data(2) = word2
        data(3) = word3
    End Sub
End Class

